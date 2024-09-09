namespace LibraryManagementWinforms
{
    partial class Login
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1 = new LibraryManagementWinforms.RoundedPanel();
            this.pictLabel1 = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel2 = new LibraryManagementWinforms.RoundedPanel();
            this.pictLabel2 = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel3 = new LibraryManagementWinforms.RoundedPanel();
            this.LblWarn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.roundedPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.roundedPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.roundedPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(1041, 595);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LibraryManagementWinforms.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(767, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Close);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.pictLabel1);
            this.roundedPanel1.Location = new System.Drawing.Point(31, 220);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.roundedPanel1.Size = new System.Drawing.Size(151, 56);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.Click += new System.EventHandler(this.StaffCilck);
            this.roundedPanel1.MouseEnter += new System.EventHandler(this.PanelEnter);
            this.roundedPanel1.MouseLeave += new System.EventHandler(this.PanelLeave);
            // 
            // pictLabel1
            // 
            this.pictLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLabel1.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictLabel1.LblText = "Staff";
            this.pictLabel1.Location = new System.Drawing.Point(10, 10);
            this.pictLabel1.Name = "pictLabel1";
            this.pictLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.pictLabel1.Picture = global::LibraryManagementWinforms.Properties.Resources.user;
            this.pictLabel1.Size = new System.Drawing.Size(131, 36);
            this.pictLabel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLabel1.TabIndex = 0;
            this.pictLabel1.Load += new System.EventHandler(this.pictLabel1_Load);
            this.pictLabel1.Click += new System.EventHandler(this.StaffCilck);
            this.pictLabel1.MouseEnter += new System.EventHandler(this.LoginMouseEnter);
            this.pictLabel1.MouseLeave += new System.EventHandler(this.LoginMouseLeave);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.pictLabel2);
            this.roundedPanel2.Location = new System.Drawing.Point(31, 291);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.roundedPanel2.Size = new System.Drawing.Size(151, 56);
            this.roundedPanel2.TabIndex = 3;
            this.roundedPanel2.Click += new System.EventHandler(this.MemberClick);
            this.roundedPanel2.MouseEnter += new System.EventHandler(this.PanelEnter);
            this.roundedPanel2.MouseLeave += new System.EventHandler(this.PanelLeave);
            // 
            // pictLabel2
            // 
            this.pictLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLabel2.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictLabel2.LblText = "Member";
            this.pictLabel2.Location = new System.Drawing.Point(10, 10);
            this.pictLabel2.Name = "pictLabel2";
            this.pictLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.pictLabel2.Picture = global::LibraryManagementWinforms.Properties.Resources.best_employee;
            this.pictLabel2.Size = new System.Drawing.Size(131, 36);
            this.pictLabel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLabel2.TabIndex = 1;
            this.pictLabel2.Click += new System.EventHandler(this.MemberClick);
            this.pictLabel2.MouseEnter += new System.EventHandler(this.LoginMouseEnter);
            this.pictLabel2.MouseLeave += new System.EventHandler(this.LoginMouseLeave);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.roundedPanel3.BorderRadius = 30;
            this.roundedPanel3.Controls.Add(this.LblWarn);
            this.roundedPanel3.Controls.Add(this.button1);
            this.roundedPanel3.Controls.Add(this.TBPass);
            this.roundedPanel3.Controls.Add(this.TBId);
            this.roundedPanel3.Controls.Add(this.label4);
            this.roundedPanel3.Controls.Add(this.label3);
            this.roundedPanel3.Controls.Add(this.label2);
            this.roundedPanel3.Location = new System.Drawing.Point(240, 145);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(315, 326);
            this.roundedPanel3.TabIndex = 0;
            // 
            // LblWarn
            // 
            this.LblWarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.LblWarn.ForeColor = System.Drawing.Color.Red;
            this.LblWarn.Location = new System.Drawing.Point(93, 221);
            this.LblWarn.Name = "LblWarn";
            this.LblWarn.Size = new System.Drawing.Size(138, 16);
            this.LblWarn.TabIndex = 6;
            this.LblWarn.Text = "Invalid Id or Password";
            this.LblWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblWarn.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(119, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBPass
            // 
            this.TBPass.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPass.Location = new System.Drawing.Point(87, 183);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(144, 24);
            this.TBPass.TabIndex = 4;
            // 
            // TBId
            // 
            this.TBId.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBId.Location = new System.Drawing.Point(88, 124);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(144, 24);
            this.TBId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Staff ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1041, 595);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private PictLabel pictLabel2;
        private PictLabel pictLabel1;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWarn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}