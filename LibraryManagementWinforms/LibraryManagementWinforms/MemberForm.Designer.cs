namespace LibraryManagementWinforms
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.PnlOpt = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel4 = new LibraryManagementWinforms.RoundedPanel();
            this.pictLabel4 = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel3 = new LibraryManagementWinforms.RoundedPanel();
            this.pictLabel3 = new LibraryManagementWinforms.PictLabel();
            this.roundedPanel2 = new LibraryManagementWinforms.RoundedPanel();
            this.pictLabel2 = new LibraryManagementWinforms.PictLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlCont = new LibraryManagementWinforms.RoundedPanelNew();
            this.PnlOpt.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
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
            this.PnlOpt.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(215, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Controls.Add(this.pictLabel4);
            this.roundedPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel4.Location = new System.Drawing.Point(3, 195);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel4.Size = new System.Drawing.Size(209, 92);
            this.roundedPanel4.TabIndex = 0;
            // 
            // pictLabel4
            // 
            this.pictLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLabel4.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictLabel4.LblText = "Logout";
            this.pictLabel4.Location = new System.Drawing.Point(5, 5);
            this.pictLabel4.Name = "pictLabel4";
            this.pictLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.pictLabel4.Picture = null;
            this.pictLabel4.Size = new System.Drawing.Size(199, 82);
            this.pictLabel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLabel4.TabIndex = 3;
            this.pictLabel4.Click += new System.EventHandler(this.Logout);
            this.pictLabel4.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pictLabel4.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Controls.Add(this.pictLabel3);
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(3, 99);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel3.Size = new System.Drawing.Size(209, 90);
            this.roundedPanel3.TabIndex = 0;
            this.roundedPanel3.Click += new System.EventHandler(this.ProfileClick);
            // 
            // pictLabel3
            // 
            this.pictLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLabel3.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictLabel3.LblText = "Profile";
            this.pictLabel3.Location = new System.Drawing.Point(5, 5);
            this.pictLabel3.Name = "pictLabel3";
            this.pictLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.pictLabel3.Picture = ((System.Drawing.Image)(resources.GetObject("pictLabel3.Picture")));
            this.pictLabel3.Size = new System.Drawing.Size(199, 80);
            this.pictLabel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLabel3.TabIndex = 2;
            this.pictLabel3.Click += new System.EventHandler(this.ProfileClick);
            this.pictLabel3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pictLabel3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.pictLabel2);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(3, 3);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.roundedPanel2.Size = new System.Drawing.Size(209, 90);
            this.roundedPanel2.TabIndex = 0;
            // 
            // pictLabel2
            // 
            this.pictLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictLabel2.LblFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictLabel2.LblText = "Books";
            this.pictLabel2.Location = new System.Drawing.Point(5, 5);
            this.pictLabel2.Name = "pictLabel2";
            this.pictLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.pictLabel2.Picture = ((System.Drawing.Image)(resources.GetObject("pictLabel2.Picture")));
            this.pictLabel2.Size = new System.Drawing.Size(199, 80);
            this.pictLabel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLabel2.TabIndex = 1;
            this.pictLabel2.Click += new System.EventHandler(this.BooksClick);
            this.pictLabel2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.pictLabel2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 77);
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
            this.pictureBox1.Size = new System.Drawing.Size(215, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PnlCont
            // 
            this.PnlCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.PnlCont.BorderRadius = 40;
            this.PnlCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCont.Location = new System.Drawing.Point(215, 0);
            this.PnlCont.Name = "PnlCont";
            this.PnlCont.Padding = new System.Windows.Forms.Padding(10);
            this.PnlCont.Size = new System.Drawing.Size(938, 536);
            this.PnlCont.TabIndex = 5;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1153, 536);
            this.Controls.Add(this.PnlCont);
            this.Controls.Add(this.PnlOpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1169, 575);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlOpt.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlOpt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PictLabel pictLabel3;
        private PictLabel pictLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel3;
        private RoundedPanelNew PnlCont;
        private RoundedPanel roundedPanel2;
        private PictLabel pictLabel2;
    }
}