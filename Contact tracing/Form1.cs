using System.IO;

namespace Contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\irinc\OneDrive\Documents\Contact tracing.text");
            file.WriteLine("Name:" + box1.Text);
            file.WriteLine("Address:" + box2.Text);
            file.WriteLine("Phone No." + box3.Text);
            file.WriteLine("Age:" + box4.Text);
            file.WriteLine("Date:" + box5.Text);
            file.WriteLine("Time in/out:" + box6.Text);
            file.Close();   
        }
    }
}