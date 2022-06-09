using System.IO;

namespace Contact_tracing
{
    public partial class Tracingform : Form
    {
        
        public Tracingform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\irinc\OneDrive\Documents\Contact tracing.text");
            file.WriteLine("Name:" + box1.Text + box2.Text);
            file.WriteLine("Address:" + box3.Text);
            file.WriteLine("Phone No." + box4.Text);
            file.WriteLine("Age:" + box5.Text);
            file.WriteLine("Date:" + box6.Text);
            file.WriteLine("Time in/out:" + box7.Text);
            file.WriteLine("1." + ques1.Text);
            file.WriteLine(rbutt1.Text + " - " + rbutt1.Checked);
            file.WriteLine(rbutt2.Text + " - " + rbutt2.Checked); 
            file.WriteLine(rbutt3.Text + " - " + rbutt3.Checked);
            file.WriteLine("2." + ques2.Text + " - " + ques2.Checked);
            file.WriteLine("3." + ques3.Text + " - " + ques3.Checked);
            file.WriteLine("4." + ques4.Text + " - " + ques4.Checked);
            file.WriteLine("5." + ques5.Text + " - " + ques5.Checked);
            file.Close();

            MessageBox.Show("Thank you for answering. Have a Blessed day!","Saved");
        }
    }
}