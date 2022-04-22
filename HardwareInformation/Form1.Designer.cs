namespace HardwareInformation
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtActivation = new System.Windows.Forms.TextBox();
            this.btnGenerateLicense = new System.Windows.Forms.Button();
            this.lblBios = new System.Windows.Forms.Label();
            this.btnBios = new System.Windows.Forms.Button();
            this.lblMac = new System.Windows.Forms.Label();
            this.btnMac = new System.Windows.Forms.Button();
            this.lblHDD = new System.Windows.Forms.Label();
            this.lblPid = new System.Windows.Forms.Label();
            this.HDDSNo = new System.Windows.Forms.Button();
            this.ProcId = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.btnEncrypt);
            this.groupBox1.Controls.Add(this.txtActivation);
            this.groupBox1.Controls.Add(this.btnGenerateLicense);
            this.groupBox1.Controls.Add(this.lblBios);
            this.groupBox1.Controls.Add(this.btnBios);
            this.groupBox1.Controls.Add(this.lblMac);
            this.groupBox1.Controls.Add(this.btnMac);
            this.groupBox1.Controls.Add(this.lblHDD);
            this.groupBox1.Controls.Add(this.lblPid);
            this.groupBox1.Controls.Add(this.HDDSNo);
            this.groupBox1.Controls.Add(this.ProcId);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(1087, 749);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Information";
            // 
            // txtActivation
            // 
            this.txtActivation.Location = new System.Drawing.Point(67, 428);
            this.txtActivation.Multiline = true;
            this.txtActivation.Name = "txtActivation";
            this.txtActivation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActivation.Size = new System.Drawing.Size(758, 299);
            this.txtActivation.TabIndex = 14;
            // 
            // btnGenerateLicense
            // 
            this.btnGenerateLicense.Location = new System.Drawing.Point(67, 356);
            this.btnGenerateLicense.Name = "btnGenerateLicense";
            this.btnGenerateLicense.Size = new System.Drawing.Size(174, 44);
            this.btnGenerateLicense.TabIndex = 13;
            this.btnGenerateLicense.Text = "Generate License";
            this.btnGenerateLicense.UseVisualStyleBackColor = true;
            this.btnGenerateLicense.Click += new System.EventHandler(this.btnGenerateLicense_Click);
            // 
            // lblBios
            // 
            this.lblBios.AutoSize = true;
            this.lblBios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBios.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBios.Location = new System.Drawing.Point(268, 266);
            this.lblBios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBios.Name = "lblBios";
            this.lblBios.Size = new System.Drawing.Size(70, 25);
            this.lblBios.TabIndex = 12;
            this.lblBios.Text = "label4";
            // 
            // btnBios
            // 
            this.btnBios.Location = new System.Drawing.Point(67, 258);
            this.btnBios.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnBios.Name = "btnBios";
            this.btnBios.Size = new System.Drawing.Size(168, 44);
            this.btnBios.TabIndex = 11;
            this.btnBios.Text = "BIOS Serail No";
            this.btnBios.UseVisualStyleBackColor = true;
            this.btnBios.Click += new System.EventHandler(this.btnBios_Click);
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMac.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMac.Location = new System.Drawing.Point(268, 195);
            this.lblMac.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(70, 25);
            this.lblMac.TabIndex = 10;
            this.lblMac.Text = "label3";
            // 
            // btnMac
            // 
            this.btnMac.Location = new System.Drawing.Point(67, 187);
            this.btnMac.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMac.Name = "btnMac";
            this.btnMac.Size = new System.Drawing.Size(168, 44);
            this.btnMac.TabIndex = 9;
            this.btnMac.Text = "MAC Address";
            this.btnMac.UseVisualStyleBackColor = true;
            this.btnMac.Click += new System.EventHandler(this.btnMac_Click);
            // 
            // lblHDD
            // 
            this.lblHDD.AutoSize = true;
            this.lblHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHDD.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHDD.Location = new System.Drawing.Point(268, 121);
            this.lblHDD.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHDD.Name = "lblHDD";
            this.lblHDD.Size = new System.Drawing.Size(70, 25);
            this.lblHDD.TabIndex = 8;
            this.lblHDD.Text = "label2";
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPid.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPid.Location = new System.Drawing.Point(268, 46);
            this.lblPid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(70, 25);
            this.lblPid.TabIndex = 7;
            this.lblPid.Text = "label1";
            // 
            // HDDSNo
            // 
            this.HDDSNo.Location = new System.Drawing.Point(67, 113);
            this.HDDSNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.HDDSNo.Name = "HDDSNo";
            this.HDDSNo.Size = new System.Drawing.Size(168, 44);
            this.HDDSNo.TabIndex = 1;
            this.HDDSNo.Text = "HDD Serail No";
            this.HDDSNo.UseVisualStyleBackColor = true;
            this.HDDSNo.Click += new System.EventHandler(this.HDDSNo_Click);
            // 
            // ProcId
            // 
            this.ProcId.Location = new System.Drawing.Point(67, 37);
            this.ProcId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ProcId.Name = "ProcId";
            this.ProcId.Size = new System.Drawing.Size(168, 44);
            this.ProcId.TabIndex = 0;
            this.ProcId.Text = "Processor Id";
            this.ProcId.UseVisualStyleBackColor = true;
            this.ProcId.Click += new System.EventHandler(this.ProcId_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(268, 356);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(174, 44);
            this.btnEncrypt.TabIndex = 15;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(471, 356);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(174, 44);
            this.btnDecrypt.TabIndex = 16;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 771);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardwareInfo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button HDDSNo;
        private System.Windows.Forms.Button ProcId;
        private System.Windows.Forms.Label lblHDD;
        private System.Windows.Forms.Label lblPid;
        private Label lblBios;
        private Button btnBios;
        private Label lblMac;
        private Button btnMac;
        private TextBox txtActivation;
        private Button btnGenerateLicense;
        private Button btnDecrypt;
        private Button btnEncrypt;
    }
}

