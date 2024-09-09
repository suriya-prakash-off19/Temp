namespace UserControls
{
    partial class PictLabel
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
            this.LabelCon = new System.Windows.Forms.Label();
            this.PictCon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictCon)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCon
            // 
            this.LabelCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCon.Location = new System.Drawing.Point(50, 5);
            this.LabelCon.Margin = new System.Windows.Forms.Padding(0);
            this.LabelCon.Name = "LabelCon";
            this.LabelCon.Padding = new System.Windows.Forms.Padding(5);
            this.LabelCon.Size = new System.Drawing.Size(194, 28);
            this.LabelCon.TabIndex = 2;
            this.LabelCon.Text = "label1";
            this.LabelCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PictCon
            // 
            this.PictCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictCon.Location = new System.Drawing.Point(5, 5);
            this.PictCon.Name = "PictCon";
            this.PictCon.Size = new System.Drawing.Size(45, 28);
            this.PictCon.TabIndex = 3;
            this.PictCon.TabStop = false;
            // 
            // PictLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCon);
            this.Controls.Add(this.PictCon);
            this.Name = "PictLabel";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(249, 38);
            ((System.ComponentModel.ISupportInitialize)(this.PictCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelCon;
        private System.Windows.Forms.PictureBox PictCon;
    }
}
