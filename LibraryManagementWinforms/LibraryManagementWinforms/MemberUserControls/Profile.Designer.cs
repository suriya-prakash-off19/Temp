namespace LibraryManagementWinforms.MemberUserControls
{
    partial class Profile
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.roundedPanel1 = new LibraryManagementWinforms.RoundedPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblContact = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.EdtProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(30);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(30);
            this.splitContainer1.Size = new System.Drawing.Size(828, 577);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.roundedPanel1.BorderRadius = 0;
            this.roundedPanel1.Controls.Add(this.tableLayoutPanel1);
            this.roundedPanel1.Controls.Add(this.EdtProd);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(30, 30);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 50);
            this.roundedPanel1.Size = new System.Drawing.Size(277, 517);
            this.roundedPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblContact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblId, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 358);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 59);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAddress
            // 
            this.LblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(121, 59);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(113, 59);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "label3";
            this.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAddress.Enter += new System.EventHandler(this.LabelResize);
            this.LblAddress.Resize += new System.EventHandler(this.LabelResize);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 59);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblContact
            // 
            this.LblContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact.Location = new System.Drawing.Point(121, 118);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(113, 59);
            this.LblContact.TabIndex = 6;
            this.LblContact.Text = "label5";
            this.LblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblContact.Enter += new System.EventHandler(this.LabelResize);
            this.LblContact.Resize += new System.EventHandler(this.LabelResize);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 59);
            this.label8.TabIndex = 7;
            this.label8.Text = "Member Type: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblType
            // 
            this.LblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(121, 177);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(113, 59);
            this.LblType.TabIndex = 8;
            this.LblType.Text = "label7";
            this.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblType.Enter += new System.EventHandler(this.LabelResize);
            this.LblType.Resize += new System.EventHandler(this.LabelResize);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 59);
            this.label10.TabIndex = 9;
            this.label10.Text = "Member ID : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblId
            // 
            this.LblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.Location = new System.Drawing.Point(121, 236);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(113, 59);
            this.LblId.TabIndex = 10;
            this.LblId.Text = "label9";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblId.Enter += new System.EventHandler(this.LabelResize);
            this.LblId.Resize += new System.EventHandler(this.LabelResize);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 63);
            this.label12.TabIndex = 11;
            this.label12.Text = "Password : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPassword
            // 
            this.LblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(121, 295);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(113, 63);
            this.LblPassword.TabIndex = 12;
            this.LblPassword.Text = "label11";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPassword.Enter += new System.EventHandler(this.LabelResize);
            this.LblPassword.Resize += new System.EventHandler(this.LabelResize);
            // 
            // LblName
            // 
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Location = new System.Drawing.Point(121, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(113, 59);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "label2";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblName.Resize += new System.EventHandler(this.LabelResize);
            // 
            // EdtProd
            // 
            this.EdtProd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EdtProd.Location = new System.Drawing.Point(20, 442);
            this.EdtProd.Name = "EdtProd";
            this.EdtProd.Size = new System.Drawing.Size(237, 25);
            this.EdtProd.TabIndex = 13;
            this.EdtProd.Text = "Edit Profile";
            this.EdtProd.UseVisualStyleBackColor = true;
            this.EdtProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::LibraryManagementWinforms.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(427, 517);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.ISBN,
            this.BookName,
            this.Date,
            this.Fine});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(407, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sno
            // 
            this.Sno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sno.DividerWidth = 2;
            this.Sno.HeaderText = "Sno";
            this.Sno.Name = "Sno";
            this.Sno.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.HeaderText = "Name";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fine
            // 
            this.Fine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fine.HeaderText = "Fine";
            this.Fine.Name = "Fine";
            this.Fine.ReadOnly = true;
            this.Fine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(828, 577);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EdtProd;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fine;
        private System.Windows.Forms.Label LblName;
    }
}
