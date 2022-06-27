namespace Contact_tracing
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recobydate
            // 
            this.recobydate.BackColor = System.Drawing.Color.Snow;
            this.recobydate.Location = new System.Drawing.Point(22, 391);
            this.recobydate.Multiline = true;
            this.recobydate.Name = "recobydate";
            this.recobydate.Size = new System.Drawing.Size(474, 190);
            this.recobydate.TabIndex = 1;
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.Transparent;
            this.customers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customers.Location = new System.Drawing.Point(22, 152);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(152, 26);
            this.customers.TabIndex = 2;
            this.customers.Text = "List of Customers:";
            // 
            // infos
            // 
            this.infos.AutoSize = true;
            this.infos.BackColor = System.Drawing.Color.Transparent;
            this.infos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infos.Location = new System.Drawing.Point(22, 365);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(191, 23);
            this.infos.TabIndex = 3;
            this.infos.Text = "Customers Information:";
            // 
            // allreco
            // 
            this.allreco.BackColor = System.Drawing.Color.Snow;
            this.allreco.Location = new System.Drawing.Point(22, 180);
            this.allreco.Multiline = true;
            this.allreco.Name = "allreco";
            this.allreco.Size = new System.Drawing.Size(474, 164);
            this.allreco.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Contact_tracing.Properties.Resources.OIP2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(583, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 94);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 267);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 34);
            this.textBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(510, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Select date:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.details.Location = new System.Drawing.Point(511, 391);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(115, 36);
            this.details.TabIndex = 10;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Contact_tracing.Properties.Resources.Chicken_joy_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 611);
            this.Controls.Add(this.details);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allreco);
            this.Controls.Add(this.infos);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.recobydate);
            this.Name = "Form2";
            this.Text = "Customers Informations List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox recobydate;
        private Label customers;
        private Label infos;
        private TextBox allreco;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private Button button2;
        private Button details;
    }
}