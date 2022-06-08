using System.IO;

namespace Contact_tracing
{
    public partial class Form1 : Form
    {
        string Checked = "";
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
            file.WriteLine("Question 1." + ques1.Text + ques1.Checked);
            file.WriteLine("Question 2." + ques1.Text + ques2.Checked);
            file.WriteLine("Question 3." + ques1.Text + ques3.Checked);
            file.WriteLine("Question 4." + ques1.Text + ques4.Checked);
            file.WriteLine("Question 5." + ques1.Text + ques5.Checked);
            file.Close();

            MessageBox.Show("Thank you for answering.","Saved");
        }
    }
}