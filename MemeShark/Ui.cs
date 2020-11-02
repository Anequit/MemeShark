using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

    }
}
