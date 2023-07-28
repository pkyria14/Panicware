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

namespace PanicWareGui.Forms
{
    public partial class FormEncryptions : Form
    {
        public FormEncryptions()
        {
            InitializeComponent();
        }

        private void btncook_Click(object sender, EventArgs e)
        {
            // Get the input plaintext from the PlaintextInputBox
            string plaintext = PlaintextInputBox.Text;

            // ----

            // Check if encryption algorithm was selected
            // If not print error

            // Check if output format was selected
            // If not print error

            // Call the chosen encryption function
            string encrypted = EncryptionsMain.Encryptions.Encrypt(plaintext);   //encryptions.Main(plaintext);

            // Prompt to choose where to ouput the processed file

            // Output the file in the directory of the user's choice
            // ----
            // Set the encrypted output as the text of the EncryptedOutputBox
            EncryptedOutputBox.Text = encrypted;
        }

        private void btn_file_to_encrypt(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files (*.bin)|*.bin"; // Specify the file filter if needed

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                // Process the selected file here (e.g., read its contents)
                // You can pass the selectedFilePath to your encryption function or store it for later use
            }
        }
    }
}
