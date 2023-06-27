using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionsMain
{
    public class Encryptions
    {
        static byte[] XOR(byte[] inputBytes)
        {
            // Constant key 
            byte[] keyBytes = new byte[] { 0xAB, 0xCD, 0xEF, 0x54, 0xde, 0xad, 0xbe, 0xef };

            // Create a new byte array to store the encrypted data
            byte[] encryptedBytes = new byte[inputBytes.Length];

            // Apply XOR operation to each byte in inputBytes using corresponding byte in keyBytes
            for (int i = 0; i < inputBytes.Length; i++)
            {
                encryptedBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }

            return encryptedBytes;
        }

        public static string Encrypt(string plaintext)
        {
            string contents = plaintext;
            try
            {
                // Read all bytes from the file
                /*using (StreamReader reader = new StreamReader("C:\\Users\\kyria\\Desktop\\github\\ShellcodeLoaderGPT\\Encryptions\\payload.txt", Encoding.GetEncoding("UTF-8"), true))
                {
                    contents = reader.ReadToEnd();
                }*/

                string[] hexValues = contents.Split(',');
                byte[] rawcode = new byte[hexValues.Length];

                for (int i = 0; i < hexValues.Length; i++)
                {
                    rawcode[i] = Convert.ToByte(hexValues[i], 16);
                }

                // Xor encryption
                byte[] output = XOR(rawcode);

                // Base64 encoding
                string bxoredstring = Convert.ToBase64String(output);

                /* Write the output in the output.txt
                using (StreamWriter sw = new StreamWriter("C:\\Users\\kyria\\Desktop\\base64.txt"))
                {
                    sw.WriteLine(bxoredstring);
                }
                */
                return bxoredstring;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Process completed");
            }

            return "Encryption Error!";
        }
    }
}
