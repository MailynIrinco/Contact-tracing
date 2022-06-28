namespace Contact_tracing
{
    partial class informationlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recobydate = new System.Windows.Forms.TextBox();
            this.customers = new System.Windows.Forms.Label();
            this.infos = new System.Windows.Forms.Label();
            this.allreco = new System.Windows.Forms.TextBox();
            this.pic2 = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.datebox = new System.Windows.Forms.TextBox();
            this.selectdate = new System.Windows.Forms.Button();
            this.listdetails = new System.Windows.Forms.Button();
            this.lex = new System.Windows.Forms.Label();
            this.may = new System.Windows.Forms.Label();
            this.ric = new System.Windows.Forms.Label();
            this.susane = new System.Windows.Forms.Label();
            this.names = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // recobydate
            // 
            this.recobydate.BackColor = System.Drawing.Color.Snow;
            this.recobydate.Location = new System.Drawing.Point(22, 180);
            this.recobydate.Multiline = true;
            this.recobydate.Name = "recobydate";
            this.recobydate.Size = new System.Drawing.Size(474, 168);
            this.recobydate.TabIndex = 1;
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.Transparent;
            this.customers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customers.Location = new System.Drawing.Point(22, 362);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(152, 26);
            this.customers.TabIndex = 2;
            this.customers.Text = "Informations:";
            // 
            // infos
            // 
            this.infos.AutoSize = true;
            this.infos.BackColor = System.Drawing.Color.Transparent;
            this.infos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infos.Location = new System.Drawing.Point(22, 154);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(191, 23);
            this.infos.TabIndex = 3;
            this.infos.Text = "Customers Information:";
            // 
            // allreco
            // 
            this.allreco.BackColor = System.Drawing.Color.Snow;
            this.allreco.Location = new System.Drawing.Point(22, 391);
            this.allreco.Multiline = true;
            this.allreco.Name = "allreco";
            this.allreco.ReadOnly = true;
            this.allreco.Size = new System.Drawing.Size(474, 173);
            this.allreco.TabIndex = 4;
            this.allreco.TextChanged += new System.EventHandler(this.allreco_TextChanged);
            // 
            // pic2
            // 
            this.pic2.BackgroundImage = global::Contact_tracing.Properties.Resources.OIP2;
            this.pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic2.Location = new System.Drawing.Point(583, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(121, 94);
            this.pic2.TabIndex = 5;
            this.pic2.UseVisualStyleBackColor = true;
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(290, 38);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(273, 27);
            this.calendar.TabIndex = 7;
            // 
            // datebox
            // 
            this.datebox.Location = new System.Drawing.Point(511, 229);
            this.datebox.Multiline = true;
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(143, 34);
            this.datebox.TabIndex = 8;
            this.datebox.TextChanged += new System.EventHandler(this.datebox_TextChanged);
            // 
            // selectdate
            // 
            this.selectdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectdate.Location = new System.Drawing.Point(510, 190);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(144, 33);
            this.selectdate.TabIndex = 9;
            this.selectdate.Text = "Select date:";
            this.selectdate.UseVisualStyleBackColor = true;
            this.selectdate.Click += new System.EventHandler(this.selectdate_Click);
            // 
            // listdetails
            // 
            this.listdetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listdetails.Location = new System.Drawing.Point(511, 289);
            this.listdetails.Name = "listdetails";
            this.listdetails.Size = new System.Drawing.Size(143, 36);
            this.listdetails.TabIndex = 10;
            this.listdetails.Text = "List of Details";
            this.listdetails.UseVisualStyleBackColor = true;
            this.listdetails.Click += new System.EventHandler(this.details_Click);
            // 
            // lex
            // 
            this.lex.Location = new System.Drawing.Point(515, 428);
            this.lex.Name = "lex";
            this.lex.Size = new System.Drawing.Size(113, 34);
            this.lex.TabIndex = 11;
            this.lex.Text = "Lex Lee";
            this.lex.Click += new System.EventHandler(this.lex_Click);
            // 
            // may
            // 
            this.may.Location = new System.Drawing.Point(515, 462);
            this.may.Name = "may";
            this.may.Size = new System.Drawing.Size(113, 34);
            this.may.TabIndex = 12;
            this.may.Text = "May Lee";
            this.may.Click += new System.EventHandler(this.may_Click);
            // 
            // ric
            // 
            this.ric.Location = new System.Drawing.Point(515, 496);
            this.ric.Name = "ric";
            this.ric.Size = new System.Drawing.Size(113, 34);
            this.ric.TabIndex = 13;
            this.ric.Text = "Ric O";
            this.ric.Click += new System.EventHandler(this.ric_Click);
            // 
            // susane
            // 
            this.susane.Location = new System.Drawing.Point(515, 530);
            this.susane.Name = "susane";
            this.susane.Size = new System.Drawing.Size(113, 34);
            this.susane.TabIndex = 14;
            this.susane.Text = "Susane Yee";
            this.susane.Click += new System.EventHandler(this.susane_Click);
            // 
            // names
            // 
            this.names.BackColor = System.Drawing.Color.WhiteSmoke;
            this.names.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.names.Location = new System.Drawing.Point(515, 391);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(113, 26);
            this.names.TabIndex = 15;
            this.names.Text = "Names:";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(470, 180);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 168);
            this.vScrollBar1.TabIndex = 16;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(470, 391);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(26, 173);
            this.vScrollBar2.TabIndex = 17;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // informationlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Contact_tracing.Properties.Resources.Chicken_joy_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 611);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.names);
            this.Controls.Add(this.susane);
            this.Controls.Add(this.ric);
            this.Controls.Add(this.may);
            this.Controls.Add(this.lex);
            this.Controls.Add(this.listdetails);
            this.Controls.Add(this.selectdate);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.allreco);
            this.Controls.Add(this.infos);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.recobydate);
            this.Name = "informationlist";
            this.Text = "Customers Informations List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox recobydate;
        private Label customers;
        private Label infos;
        private TextBox allreco;
        private Button pic2;
        private DateTimePicker calendar;
        private TextBox datebox;
        private Button selectdate;
        private Button listdetails;
        private Label lex;
        private Label may;
        private Label ric;
        private Label susane;
        private Label names;
        private VScrollBar vScrollBar1;
        private VScrollBar vScrollBar2;
    }
}