namespace LibraryManagementWinforms.MemberUserControls
{
    partial class BuyBook
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblISBN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblAvail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblNOI = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.roundedPanel1.BorderRadius = 40;
            this.roundedPanel1.Controls.Add(this.button1);
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel1);
            this.roundedPanel1.Controls.Add(this.pictureBox2);
            this.roundedPanel1.Location = new System.Drawing.Point(189, 21);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(389, 505);
            this.roundedPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(137, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rent Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblAuthor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblISBN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblAvail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblNOI, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 261);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblName
            // 
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(163, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(155, 52);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "label2";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAuthor
            // 
            this.LblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(163, 52);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(155, 52);
            this.LblAuthor.TabIndex = 3;
            this.LblAuthor.Text = "label4";
            this.LblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 52);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISBN : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblISBN
            // 
            this.LblISBN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblISBN.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblISBN.Location = new System.Drawing.Point(163, 104);
            this.LblISBN.Name = "LblISBN";
            this.LblISBN.Size = new System.Drawing.Size(155, 52);
            this.LblISBN.TabIndex = 5;
            this.LblISBN.Text = "label6";
            this.LblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 52);
            this.label9.TabIndex = 8;
            this.label9.Text = "Availability : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAvail
            // 
            this.LblAvail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAvail.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvail.Location = new System.Drawing.Point(163, 156);
            this.LblAvail.Name = "LblAvail";
            this.LblAvail.Size = new System.Drawing.Size(155, 52);
            this.LblAvail.TabIndex = 9;
            this.LblAvail.Text = "label10";
            this.LblAvail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 53);
            this.label11.TabIndex = 10;
            this.label11.Text = "No of Items";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNOI
            // 
            this.LblNOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNOI.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNOI.Location = new System.Drawing.Point(163, 208);
            this.LblNOI.Name = "LblNOI";
            this.LblNOI.Size = new System.Drawing.Size(155, 53);
            this.LblNOI.TabIndex = 11;
            this.LblNOI.Text = "label12";
            this.LblNOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManagementWinforms.Properties.Resources.book__1_;
            this.pictureBox2.Location = new System.Drawing.Point(128, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BuyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "BuyBook";
            this.Size = new System.Drawing.Size(750, 577);
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblISBN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblAvail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblNOI;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
