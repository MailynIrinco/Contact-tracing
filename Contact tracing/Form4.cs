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

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
     
        private void scanbtn_Click(object sender, EventArgs e)
        {
           captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame1;
            captureDevice.Start();

        }

        private void CaptureDevice_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
          
        }

        private void scanqrc_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void scanqrc_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;

        }
    }
}
