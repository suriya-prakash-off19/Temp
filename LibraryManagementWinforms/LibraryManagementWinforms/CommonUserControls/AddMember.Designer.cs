namespace LibraryManagementWinforms.CommonUserControls
{
    partial class AddMember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new LibraryManagementWinforms.RoundedPanel();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.TxtConPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.roundedPanel1.BorderRadius = 30;
            this.roundedPanel1.Controls.Add(this.BtnRemove);
            this.roundedPanel1.Controls.Add(this.BtnSave);
            this.roundedPanel1.Controls.Add(this.CmbType);
            this.roundedPanel1.Controls.Add(this.TxtConPassword);
            this.roundedPanel1.Controls.Add(this.TxtPassword);
            this.roundedPanel1.Controls.Add(this.TxtContact);
            this.roundedPanel1.Controls.Add(this.TxtAddress);
            this.roundedPanel1.Controls.Add(this.TxtName);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.label5);
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Location = new System.Drawing.Point(155, 13);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(436, 523);
            this.roundedPanel1.TabIndex = 0;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRemove.Location = new System.Drawing.Point(154, 477);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(128, 34);
            this.BtnRemove.TabIndex = 14;
            this.BtnRemove.Text = "REMOVE";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Visible = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSave.Location = new System.Drawing.Point(154, 437);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(128, 34);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CmbType
            // 
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Basic",
            "Pro",
            "Premium"});
            this.CmbType.Location = new System.Drawing.Point(223, 304);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(120, 23);
            this.CmbType.TabIndex = 12;
            // 
            // TxtConPassword
            // 
            this.TxtConPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConPassword.Location = new System.Drawing.Point(223, 391);
            this.TxtConPassword.Name = "TxtConPassword";
            this.TxtConPassword.Size = new System.Drawing.Size(120, 22);
            this.TxtConPassword.TabIndex = 11;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(223, 347);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(120, 22);
            this.TxtPassword.TabIndex = 10;
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(223, 260);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(120, 22);
            this.TxtContact.TabIndex = 9;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(223, 211);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(120, 22);
            this.TxtAddress.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(223, 167);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(120, 22);
            this.TxtName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Confirm Password :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Membership Type : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementWinforms.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(154, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "AddMember";
            this.Size = new System.Drawing.Size(750, 547);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.TextBox TxtConPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnRemove;
    }
}
