using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;

namespace Contact_tracing
{
    public partial class qrcode : Form
    {
        public qrcode()
        {
            InitializeComponent();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
           QRCoder.QRCodeGenerator qc = new QRCoder.QRCodeGenerator();
            var MyData = qc.CreateQrCode(namebox.Text, QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            qrpic.Image = code.GetGraphic(50);

        }

        private void scan_Click(object sender, EventArgs e)
        {

        }

        private void qrcode_Load(object sender, EventArgs e)
        {
         
        }

        public void Retrive()
        {
            throw new NotImplementedException();    
        }
    }
}
