using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace Contact_tracing
{
    public partial class scanqrc : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public scanqrc()
        {
            InitializeComponent();
        }

       
        private void scanbtn_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cboDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            scanbox.Image = (Bitmap)eventArgs.Frame.Clone();
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
            if (FinalFrame.IsRunning==true)
                FinalFrame.Stop();  
            
        }

        private void scanqrc_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo Device in CaptureDevice)
                cboDevice.Items.Add(Device.Name);

            cboDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
