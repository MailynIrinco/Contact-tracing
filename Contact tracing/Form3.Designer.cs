namespace Contact_tracing
{
    partial class qrcode
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
            this.create = new System.Windows.Forms.Button();
            this.infobox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.qrpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create.ForeColor = System.Drawing.Color.DarkRed;
            this.create.Location = new System.Drawing.Point(140, 491);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(137, 39);
            this.create.TabIndex = 0;
            this.create.Text = "Create QR";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // infobox
            // 
            this.infobox.Location = new System.Drawing.Point(119, 114);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(293, 27);
            this.infobox.TabIndex = 2;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(105, 51);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(307, 27);
            this.namebox.TabIndex = 3;
            // 
            // fname
            // 
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fname.ForeColor = System.Drawing.Color.DarkRed;
            this.fname.Location = new System.Drawing.Point(12, 53);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(87, 25);
            this.fname.TabIndex = 4;
            this.fname.Text = "File name:";
            this.fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // info
            // 
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info.ForeColor = System.Drawing.Color.DarkRed;
            this.info.Location = new System.Drawing.Point(12, 117);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(101, 24);
            this.info.TabIndex = 5;
            this.info.Text = "Information:";
            // 
            // qrpic
            // 
            this.qrpic.BackColor = System.Drawing.Color.White;
            this.qrpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.qrpic.Location = new System.Drawing.Point(44, 177);
            this.qrpic.Name = "qrpic";
            this.qrpic.Size = new System.Drawing.Size(344, 296);
            this.qrpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrpic.TabIndex = 7;
            this.qrpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Creating QRCode";
            // 
            // qrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(435, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrpic);
            this.Controls.Add(this.info);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.infobox);
            this.Controls.Add(this.create);
            this.Name = "qrcode";
            this.Text = "Create QRCode";
            this.Load += new System.EventHandler(this.qrcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button create;
        private TextBox infobox;
        private TextBox namebox;
        private Label fname;
        private Label info;
        private PictureBox qrpic;
        private Label label1;
    }
}