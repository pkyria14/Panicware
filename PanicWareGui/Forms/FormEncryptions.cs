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

namespace PanicWareGui.Forms
{
    public partial class FormEncryptions : Form
    {
        public FormEncryptions()
        {
            InitializeComponent();
        }

        private void cook_encryptions_Click(object sender, EventArgs e)
        {
            // Get the input plaintext from the PlaintextInputBox
            string plaintext = PlaintextInputBox.Text;

            // Call the encryption function and get the encrypted output
            string encrypted = EncryptionsMain.Encryptions.Main(plaintext);   //encryptions.Main(plaintext);

            // Set the encrypted output as the text of the EncryptedOutputBox
            EncryptedOutputBox.Text = encrypted;

        }
    }
}
