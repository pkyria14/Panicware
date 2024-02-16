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
using System.Globalization;

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
            // Check if a file was selected
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select a file first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if an encryption algorithm was selected
            if (!radioAes256.Checked && !radioRc4.Checked && !radioXor.Checked && !radioBase64.Checked)
            {
                MessageBox.Show("Please select an encryption algorithm.", "No Algorithm Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if an output format was selected
            string outputFormat = "";
            if (radioDll.Checked)
            {
                outputFormat = "DLL";
            }
            else if (radioRaw.Checked)
            {
                outputFormat = "RAW";
            }
            else if (radioExe.Checked)
            {
                outputFormat = "EXE";
            }
            else if (radioElf.Checked)
            {
                outputFormat = "ELF";
            }
            else
            {
                MessageBox.Show("Please select an output format.", "No Output Format Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] fileContent = File.ReadAllBytes(selectedFilePath);
            byte[] encryptedContent = null; // Initialize as byte array
            string algorithmName = "";

            /*if (radioAes256.Checked)
            {
                algorithmName = "AES-256";
                string aes_key = GetUserKey();
                encryptedContent = Encryptions.radioAES256(fileContent, aes_key, outputFormat);
            }
            else if (radioRc4.Checked)
            {
                algorithmName = "RC4";
                string rc4_key = GetUserKey();
                encryptedContent = Encryptions.radioRC4(fileContent, rc4_key, outputFormat);
            }*/
            if (radioXor.Checked)
            {
                algorithmName = "XOR";
                string xor_key = GetUserKey();
                encryptedContent = Encryptions.radioXOR(fileContent, xor_key);
            }
            /*else if (radioBase64.Checked)
            {
                algorithmName = "Base64";
                encryptedContent = Encryptions.radioBase64(fileContent, outputFormat);
            }*/
            else
            {
                MessageBox.Show("Please select an encryption algorithm.", "No Algorithm Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the encrypted content to a file
            SaveEncryptedContent(encryptedContent, algorithmName, selectedFilePath);

            // Pseudo-code for embedding encrypted content into the template executable
            // This would be a manual step or an advanced automated step
            EmbedPayloadInTemplateExecutable(encryptedContent);

            // Pseudo-code for compiling the template project to produce the final executable
            // This step is also either manual or requires advanced automation
            CompileTemplateExecutable();
        }

        void EmbedPayloadInTemplateExecutable(byte[] payload)
        {
            // Manual step: Add payload as a resource to the template project
            // or use command-line tools/MSBuild to automate
        }

        void CompileTemplateExecutable()
        {
            // Manual step: Compile the project from Visual Studio or command line
            // or use MSBuild automation from within this application
        }

        public static byte[] DecryptData(byte[] fileContent, string xor_key)
        {
            // Assuming you have the XorEncryptDecrypt method defined
            return Encryptions.radioXOR(fileContent, xor_key);
        }

        private void btn_file_to_encrypt(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C# Files (*.cs)|*.cs"; // Adjust the filter to select C# files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                btnFileToEncrypt.Text = Path.GetFileName(selectedFilePath);
            }
            else
            {
                btnFileToEncrypt.Text = "No file selected.";
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
        private void SaveEncryptedContent(byte[] encryptedContent, string algorithmName, string originalFilePath)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Encrypted File (*.enc)|*.enc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                File.WriteAllBytes(savePath, encryptedContent);

                // Optionally, show the file in Explorer
                System.Diagnostics.Process.Start("explorer.exe", "/select, \"" + savePath + "\"");

                // Show a popup message with the encryption details
                MessageBox.Show($"File '{Path.GetFileName(originalFilePath)}' was encrypted with {algorithmName} and saved to '{savePath}'.", "Encryption Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
