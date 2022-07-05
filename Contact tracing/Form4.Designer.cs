namespace Contact_tracing
{
    partial class scanqrc
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
            this.scanbtn = new System.Windows.Forms.Button();
            this.scanbox = new System.Windows.Forms.PictureBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scanbox)).BeginInit();
            this.SuspendLayout();
            // 
            // scanbtn
            // 
            this.scanbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scanbtn.Location = new System.Drawing.Point(56, 383);
            this.scanbtn.Name = "scanbtn";
            this.scanbtn.Size = new System.Drawing.Size(106, 38);
            this.scanbtn.TabIndex = 0;
            this.scanbtn.Text = "SCAN";
            this.scanbtn.UseVisualStyleBackColor = true;
            this.scanbtn.Click += new System.EventHandler(this.scanbtn_Click);
            // 
            // scanbox
            // 
            this.scanbox.Location = new System.Drawing.Point(44, 64);
            this.scanbox.Name = "scanbox";
            this.scanbox.Size = new System.Drawing.Size(323, 296);
            this.scanbox.TabIndex = 1;
            this.scanbox.TabStop = false;
            // 
            // okbtn
            // 
            this.okbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okbtn.Location = new System.Drawing.Point(242, 383);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(106, 38);
            this.okbtn.TabIndex = 2;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(44, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(153, 27);
            this.name.TabIndex = 3;
            this.name.Text = "QRCode Scanner";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(216, 20);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(151, 28);
            this.cboDevice.TabIndex = 4;
            // 
            // scanqrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(414, 446);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.scanbox);
            this.Controls.Add(this.scanbtn);
            this.Name = "scanqrc";
            this.Text = "Scan a QRCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.scanqrc_FormClosing);
            this.Load += new System.EventHandler(this.scanqrc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scanbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button scanbtn;
        private PictureBox scanbox;
        private Button okbtn;
        private Label name;
        private ComboBox cboDevice;
    }
}