using MemeShark.Core;
using MemeShark.Data;
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

            // If there isn't a config file present, then it will be created. 
            // Planned to write defaults if config isn't present. ***********************************************
            if (!File.Exists("config.json"))
                File.Create("config.json");

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            // find all grabber processes and close them
            Process[] processes = Process.GetProcessesByName("Grabber");
            foreach (var process in processes)
                process.Kill();

            // Start the grabber
            Process.Start("./Grabber/Grabber.exe");
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            // Stop all grabber processes
            Process[] processes = Process.GetProcessesByName("Grabber");
            foreach (var process in processes)
                process.Kill();
        }

        private void BrowserSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Save to config

        }
    }
}
