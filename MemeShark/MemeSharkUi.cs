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

namespace MemeShark
{
    public partial class MemeSharkUi : Form
    {
        public MemeSharkUi()
        {
            /**
            - starts the grabber
	        - stops the grabber
	        - Writes/Reads to config
	        - Manages the grabber
	        - Read from links.json and download
            **/

            InitializeComponent();

            if (!File.Exists("config.json"))
                File.Create("config.json");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("Grabber");
            foreach (var process in processes)
                process.Kill();

            Process.Start("./Grabber/Grabber.exe");
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("Grabber");
            foreach (var process in processes)
                process.Kill();
        }
    }
}
