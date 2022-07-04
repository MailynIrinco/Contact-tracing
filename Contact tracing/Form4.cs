using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Contact_tracing
{
    public partial class scanqrc : Form
    {
        public scanqrc()
        {
            InitializeComponent();
        }

     
        private void scanbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
          
        }

        private void scanqrc_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
