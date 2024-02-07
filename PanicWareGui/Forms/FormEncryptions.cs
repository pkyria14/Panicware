using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionsMain;
using System.Timers;
using System.IO;
using System.Security.Cryptography;

namespace PanicWareGui.Forms
{
    public partial class FormEncryptions : Form
    {
        private string selectedFilePath;

        public FormEncryptions()
        {
            InitializeComponent();
        }

        private void btncook_Click(object sender, EventArgs e)
        {
            // Get the input plaintext from the PlaintextInputBox
            //string plaintext = PlaintextInputBox.Text;

            // ----

            // Check if encryption algorithm was selected
            // If not print error

            // Check if output format was selected
            // If not print error

            // Call the chosen encryption function
            //string encrypted = EncryptionsMain.Encryptions.Encrypt(plaintext);   //encryptions.Main(plaintext);

            // Prompt to choose where to ouput the processed file

            // Output the file in the directory of the user's choice
            // ----
            // Set the encrypted output as the text of the EncryptedOutputBox
            //EncryptedOutputBox.Text = encrypted;
        }

        private void btn_file_to_encrypt(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C# Files (*.cs)|*.cs"; // Adjust the filter to select C# files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(selectedFilePath);

                // Determine which encryption algorithm is selected
                string encryptedContent = "";
                string algorithmName = "";
                String aes_key, rc4_key, xor_key, ekko_key = "";

                if (radioAes256.Checked)
                {
                    algorithmName = "AES256";
                    aes_key = GetUserKey();
                    encryptedContent = Encryptions.radioAES256(fileContent, aes_key);
                }
                else if (radioRc4.Checked)
                {
                    algorithmName = "RC4";
                    rc4_key = GetUserKey();
                    encryptedContent = Encryptions.radioRC4(fileContent, rc4_key);
                }
                else if (radioXor.Checked)
                {
                    algorithmName = "XOR";
                    xor_key = GetUserKey();
                    encryptedContent = Encryptions.radioXOR(fileContent, xor_key);
                }
                else if (radioEkko.Checked)
                {
                    algorithmName = "Ekko";
                    ekko_key = GetUserKey();
                    encryptedContent = Encryptions.radioEkko(fileContent, ekko_key);
                }
                // Add other conditions for each supported algorithm
                else if (radioBase64.Checked)
                {
                    encryptedContent = Encryptions.radioBase64(fileContent);
                }
                // You'll need to implement EncryptWithRC4, EncryptWithXOR, etc., and ConvertToBase64 based on your needs

                // Save the encrypted content to a file
                SaveEncryptedContent(encryptedContent, algorithmName, selectedFilePath);
            }
            else
            {
                MessageBox.Show("Please select a file to encrypt first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Example: Prompt the user for a key
        private string GetUserKey()
        {
            // Show a dialog to get the key from the user. Implement this based on your UI design.
            // This could be a simple input box or a custom form.
            return Microsoft.VisualBasic.Interaction.InputBox("Please enter the encryption key:", "Encryption Key", "", -1, -1);
        }

        // Example: Save encrypted content to a file
        private void SaveEncryptedContent(string encryptedContent, string algorithmName, string originalFilePath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Encrypted File (*.enc)|*.enc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                File.WriteAllText(savePath, encryptedContent);

                // Optionally, show the file in Explorer
                System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + savePath + "\"");

                // Show a popup message with the encryption details
                MessageBox.Show($"File '{Path.GetFileName(originalFilePath)}' was encrypted with {algorithmName} and saved to '{savePath}'.", "Encryption Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
