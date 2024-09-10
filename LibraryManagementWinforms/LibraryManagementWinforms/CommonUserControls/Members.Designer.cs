namespace LibraryManagementWinforms.CommonUserControls
{
    partial class Members
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddMember = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBar1 = new LibraryManagementWinforms.SearchBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddMember);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.searchBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25, 5, 20, 5);
            this.panel1.Size = new System.Drawing.Size(863, 49);
            this.panel1.TabIndex = 0;
            // 
            // AddMember
            // 
            this.AddMember.BackColor = System.Drawing.Color.DarkGreen;
            this.AddMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMember.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddMember.Location = new System.Drawing.Point(735, 5);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(108, 39);
            this.AddMember.TabIndex = 2;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = false;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "ID",
            "Address",
            "Contact",
            "Membership Type"});
            this.comboBox1.Location = new System.Drawing.Point(390, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchBar1
            // 
            this.searchBar1.BackColor = System.Drawing.Color.Silver;
            this.searchBar1.BorderRadius = 30;
            this.searchBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchBar1.Location = new System.Drawing.Point(25, 5);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.searchBar1.Size = new System.Drawing.Size(346, 39);
            this.searchBar1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 59);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(863, 436);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sno,
            this.MemberName,
            this.ID,
            this.Address,
            this.Contact,
            this.MembershipType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(197)))), ((int)(((byte)(235)))));
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(853, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Sno
            // 
            this.Sno.HeaderText = "Sno";
            this.Sno.Name = "Sno";
            this.Sno.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "Member ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // MembershipType
            // 
            this.MembershipType.HeaderText = "Type";
            this.MembershipType.Name = "MembershipType";
            this.MembershipType.ReadOnly = true;
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Members";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(883, 505);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private SearchBar searchBar1;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipType;
    }
}
