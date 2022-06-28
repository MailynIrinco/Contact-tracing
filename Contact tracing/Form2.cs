using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void selectdate_Click(object sender, EventArgs e)
        {
            //if (datebox.Text = @"C:\Users\irinc\OneDrive\Documents\_" + firstname.Text)
            {

            }
            //datebox.Text = Afile
            //Afile.Text = recobydate
        }

        private void details_Click(object sender, EventArgs e)
        {
            //string filepath = @"C: \Users\irinc\OneDrive\Documents\_Lex";
            
            //StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Lex");
            //allreco.Text = contact.ReadToEnd();
            //contact.Close();
        }

        private void datebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void allreco_TextChanged(object sender, EventArgs e)
        {
              


        }

        private void lex_Click(object sender, EventArgs e)
        {
            StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Lex");
            allreco.Text = contact.ReadToEnd();
            contact.Close();
        }

        private void may_Click(object sender, EventArgs e)
        {
            StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_May");
            allreco.Text = contact.ReadToEnd();
            contact.Close();
        }

        private void ric_Click(object sender, EventArgs e)
        { 
            StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Ric");
            allreco.Text = contact.ReadToEnd();
            contact.Close();
        }

        private void susane_Click(object sender, EventArgs e)
        {
            StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Susane");
            allreco.Text = contact.ReadToEnd();
            contact.Close();
        }
    }
}
