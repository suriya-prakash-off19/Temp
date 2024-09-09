using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementWinforms
{
    public partial class PictLabel : UserControl
    {
        public PictLabel()
        {
            InitializeComponent();
            PictCon.MouseEnter += Enter;
            PictCon.MouseLeave += Leave;
            LabelCon.MouseLeave += Leave;
            LabelCon.MouseEnter += Enter;
        }
        [Category("PictureBox")]
        public Image Picture
        {
            get => PictCon.Image;
            set
            {
                PictCon.Image = value;
            }
        }
        [Category("PictureBox")]
        public PictureBoxSizeMode SizeMode
        {
            get => PictCon.SizeMode;
            set
            {
                PictCon.SizeMode = value;
            }
        }
        [Category("PictureBox")]
        public string LblText
        {
            get => LabelCon.Text;
            set
            {
                LabelCon.Text = value;
            }
        }
        [Category("PictureBox")]
        public Font LblFont
        {
            get => LabelCon.Font;
            set
            {
                LabelCon.Font = value;
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = BackColor;
                LabelCon.BackColor = value;
                PictCon.BackColor = value;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int imgWidth = (int)(this.Width * 0.18);
            PictCon.Size = new Size(Math.Max(36, imgWidth), Math.Max(36, imgWidth));
        }
        private void Enter(object sender,EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void Leave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void LabelCon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
