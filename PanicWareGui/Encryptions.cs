using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EncryptionsMain
{
    public class Encryptions
    {
        public static byte[] radioXOR(byte[] dataBytes, string xorKey)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(xorKey); // Convert the key to bytes
            byte[] resultBytes = new byte[dataBytes.Length];

            for (int i = 0; i < dataBytes.Length; i++)
            {
                resultBytes[i] = (byte)(dataBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return resultBytes; // Return the raw byte array
        }


        // AES-256 Encryption Function
        public static string radioAES256(string plaintext, string aesKey, string outputFormat)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(aesKey.PadRight(32)); // Ensure the key is 32 bytes long
                aesAlg.IV = new byte[16]; // Using a zero IV for simplicity; in real applications, use a random IV

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plaintext);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // RC4 Encryption
        public static string radioRC4(string plaintext, string RC4_key, string outputFormat)
        {
            var key = Encoding.UTF8.GetBytes(RC4_key);
            var textBytes = Encoding.UTF8.GetBytes(plaintext);
            var cipher = new byte[textBytes.Length];

            // Key-scheduling algorithm (KSA)
            int[] S = new int[256];
            for (int i = 0; i < 256; i++)
            {
                S[i] = i;
            }

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + S[i] + key[i % key.Length]) % 256;
                // Swap values
                int temp = S[i];
                S[i] = S[j];
                S[j] = temp;
            }

            // Pseudo-random generation algorithm (PRGA)
            int iIndex = 0;
            int jIndex = 0;
            for (int k = 0; k < textBytes.Length; k++)
            {
                iIndex = (iIndex + 1) % 256;
                jIndex = (jIndex + S[iIndex]) % 256;

                // Swap values
                int temp = S[iIndex];
                S[iIndex] = S[jIndex];
                S[jIndex] = temp;

                int rnd = S[(S[iIndex] + S[jIndex]) % 256];

                cipher[k] = (byte)(textBytes[k] ^ rnd);
            }

            // Return as Base64 to ensure it's readable
            return Convert.ToBase64String(cipher);
        }


        // Base64 Encoding Function
        public static string radioBase64(string plaintext, string outputFormat)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plaintext);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
