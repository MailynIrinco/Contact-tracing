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
            string filepath = @"C:\Users\irinc\OneDrive\Documents\Ferson" + date.Text;
            
            StreamWriter contact = new StreamWriter(filepath);
            contact.WriteLine("Name:" + firstname.Text + " " + lastname.Text);            
            contact.WriteLine("Address:" + address.Text);
            contact.WriteLine("Phone No." + number.Text);
            contact.WriteLine("Age:" + age.Text);
            contact.WriteLine("Date:" + date.Text);
            contact.WriteLine("Time in/out:" + time.Text);
            contact.WriteLine("Survey:");
            contact.WriteLine("1." + vaccbox.Text);
            contact.WriteLine(rbutt1.Text + " - " + rbutt1.Checked);
            contact.WriteLine(rbutt2.Text + " - " + rbutt2.Checked);
            contact.WriteLine(rbutt3.Text + " - " + rbutt3.Checked);
            contact.WriteLine("2." + ques2.Text + " - " + ques2.Checked);
            contact.WriteLine("3." + ques3.Text + " - " + ques3.Checked);
            contact.WriteLine("4." + ques4.Text + " - " + ques4.Checked);
            contact.WriteLine("5." + ques5.Text + " - " + ques5.Checked);
            contact.Close();

        

            MessageBox.Show("Thank you for answering. Have a Safe day!", "Saved");
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void rbutt1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbutt2_CheckedChanged(object sender, EventArgs e)
        {   
        }

        private void rbutt3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Tracingform_Load(object sender, EventArgs e)
        {

        }
    }  
}