namespace LibraryManagementWinforms
{
    partial class SearchBar
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
            this.components = new System.ComponentModel.Container();
            this.Txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.Location = new System.Drawing.Point(95, 10);
            this.Txt.Multiline = true;
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(366, 29);
            this.Txt.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Pict
            // 
            this.Pict.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pict.Image = global::LibraryManagementWinforms.Properties.Resources.loupe;
            this.Pict.Location = new System.Drawing.Point(5, 10);
            this.Pict.Name = "Pict";
            this.Pict.Size = new System.Drawing.Size(90, 29);
            this.Pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pict.TabIndex = 0;
            this.Pict.TabStop = false;
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.Pict);
            this.Name = "SearchBar";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.Size = new System.Drawing.Size(466, 49);
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pict;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
