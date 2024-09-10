namespace LibraryManagementWinforms
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.PnlOpt = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel4 = new LibraryManagementWinforms.RoundedPanel();
            this.LblLogOut = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel3 = new LibraryManagementWinforms.RoundedPanel();
            this.LblProfile = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel2 = new LibraryManagementWinforms.RoundedPanel();
            this.LblBook = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel1 = new LibraryManagementWinforms.RoundedPanel();
            this.LblMember = new LibraryManagementWinforms.PictLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Container = new LibraryManagementWinforms.RoundedPanel();
            this.PnlOpt.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOpt
            // 
            this.PnlOpt.Controls.Add(this.tableLayoutPanel1);
            this.PnlOpt.Controls.Add(this.label1);
            this.PnlOpt.Controls.Add(this.pictureBox1);
            this.PnlOpt.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlOpt.Location = new System.Drawing.Point(0, 0);
            this.PnlOpt.Margin = new System.Windows.Forms.Padding(20);
            this.PnlOpt.Name = "PnlOpt";
            this.PnlOpt.Size = new System.Drawing.Size(215, 536);
            this.PnlOpt.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.31839F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.00897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Controls.Add(this.LblLogOut);
            this.roundedPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel4.Location = new System.Drawing.Point(3, 218);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel4.Size = new System.Drawing.Size(209, 69);
            this.roundedPanel4.TabIndex = 0;
            // 
            // LblLogOut
            // 
            this.LblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLogOut.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogOut.LblText = "Logout";
            this.LblLogOut.Location = new System.Drawing.Point(5, 5);
            this.LblLogOut.Name = "LblLogOut";
            this.LblLogOut.Padding = new System.Windows.Forms.Padding(5);
            this.LblLogOut.Picture = null;
            this.LblLogOut.Size = new System.Drawing.Size(199, 59);
            this.LblLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LblLogOut.TabIndex = 3;
            this.LblLogOut.Click += new System.EventHandler(this.LblLogOut_Click);
            this.LblLogOut.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.LblLogOut.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Controls.Add(this.LblProfile);
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(3, 143);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel3.Size = new System.Drawing.Size(209, 69);
            this.roundedPanel3.TabIndex = 0;
            // 
            // LblProfile
            // 
            this.LblProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblProfile.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProfile.LblText = "Profile";
            this.LblProfile.Location = new System.Drawing.Point(5, 5);
            this.LblProfile.Name = "LblProfile";
            this.LblProfile.Padding = new System.Windows.Forms.Padding(5);
            this.LblProfile.Picture = ((System.Drawing.Image)(resources.GetObject("LblProfile.Picture")));
            this.LblProfile.Size = new System.Drawing.Size(199, 59);
            this.LblProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LblProfile.TabIndex = 2;
            this.LblProfile.Click += new System.EventHandler(this.LblProfile_Click);
            this.LblProfile.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.LblProfile.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.LblBook);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(3, 75);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel2.Size = new System.Drawing.Size(209, 62);
            this.roundedPanel2.TabIndex = 0;
            // 
            // LblBook
            // 
            this.LblBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBook.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBook.LblText = "Books";
            this.LblBook.Location = new System.Drawing.Point(5, 5);
            this.LblBook.Name = "LblBook";
            this.LblBook.Padding = new System.Windows.Forms.Padding(5);
            this.LblBook.Picture = ((System.Drawing.Image)(resources.GetObject("LblBook.Picture")));
            this.LblBook.Size = new System.Drawing.Size(199, 52);
            this.LblBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LblBook.TabIndex = 1;
            this.LblBook.Click += new System.EventHandler(this.LblBook_Click);
            this.LblBook.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.LblBook.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.LblMember);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(3, 3);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel1.Size = new System.Drawing.Size(209, 66);
            this.roundedPanel1.TabIndex = 0;
            // 
            // LblMember
            // 
            this.LblMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMember.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMember.LblText = "Member";
            this.LblMember.Location = new System.Drawing.Point(5, 5);
            this.LblMember.Name = "LblMember";
            this.LblMember.Padding = new System.Windows.Forms.Padding(5);
            this.LblMember.Picture = global::LibraryManagementWinforms.Properties.Resources.best_employee;
            this.LblMember.Size = new System.Drawing.Size(199, 56);
            this.LblMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LblMember.TabIndex = 0;
            this.LblMember.Click += new System.EventHandler(this.LblMember_Click);
            this.LblMember.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.LblMember.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "House of Words";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::LibraryManagementWinforms.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Container.BorderRadius = 40;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(215, 0);
            this.Container.Name = "Container";
            this.Container.Padding = new System.Windows.Forms.Padding(20);
            this.Container.Size = new System.Drawing.Size(938, 536);
            this.Container.TabIndex = 7;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1153, 536);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.PnlOpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1169, 575);
            this.Name = "StaffForm";
            this.Text = "StaffLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlOpt.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlOpt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel roundedPanel4;
        private PictLabel LblLogOut;
        private RoundedPanel roundedPanel3;
        private PictLabel LblProfile;
        private RoundedPanel roundedPanel2;
        private PictLabel LblBook;
        private RoundedPanel roundedPanel1;
        private PictLabel LblMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel Container;
    }
}