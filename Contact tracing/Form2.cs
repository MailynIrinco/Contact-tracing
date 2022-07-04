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
    public partial class informationlist : Form
    {

        public informationlist()
        {
            InitializeComponent();
        }

        private void selectdate_Click(object sender, EventArgs e)
        {

            if (true)
            {
                StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Susane");
                recobydate.Text = contact.ReadToEnd();
                contact.Close();
            }
            if (true)
            {
                StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Lex");
                recobydate.Text = contact.ReadToEnd();
                contact.Close();
            }
            if (true)
            {
                StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Lex");
                recobydate.Text = contact.ReadToEnd();
                contact.Close();
            }
            if (true)
            {
                StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_May");
                recobydate.Text = contact.ReadToEnd();
                contact.Close();
            }
             if (!string.IsNullOrEmpty(recobydate.Text))    
            {
                StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\_Ric");
                recobydate.Text = contact.ReadToEnd();
                contact.Close();
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            StreamReader contact = new StreamReader(@"C:\Users\irinc\OneDrive\Documents\Contact Tracing.txt");
            allreco.Text = contact.ReadToEnd();
            contact.Close();
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

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void scroll2_Scroll(object sender, ScrollEventArgs e)
        {
            //allreco.scroll.Value = 
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void recobydate_TextChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Now;

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void calendar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
