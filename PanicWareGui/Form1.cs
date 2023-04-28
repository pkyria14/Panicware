using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanicWareGui
{
    public partial class Form1 : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fontLength = Properties.Resources.MotivaSansRegular_woff.Length;
            byte[] fontdata = Properties.Resources.MotivaSansRegular_woff;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            label1.Font = new Font(pfc.Families[0], 20);
            label1.Text = "PanicWare";
            label1.AutoSize = true;
            label1.Parent = panel1;
            label1.Location = new Point((panel1.Width - label1.Width) / 2, (panel1.Height - label1.Height) / 2);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
