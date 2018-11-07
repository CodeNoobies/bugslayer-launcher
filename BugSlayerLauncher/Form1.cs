using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugSlayerLauncher
{
    public partial class Form1 : Form
    {
        string file;

        public Form1()
        {
            InitializeComponent();
            file = string.Format("{0}\\Juego\\ProyectoSoftware.exe", Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = file;
            Process.Start(startInfo);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:3000");
        }
    }
}
