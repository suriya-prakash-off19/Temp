using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementWinforms
{
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
            SetUserControl();
        }

        private void SetUserControl()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.close;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Right;
            pictureBox.Size = new Size(30, 30);
            pictureBox.Click += Exit;
            pictureBox.Cursor = Cursors.Hand;
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Controls.Add(pictureBox);
            panel.Size = new Size(40, 40);
            panel.Padding = new Padding(5);
            this.Controls.Add(panel);

        }

        private void Exit(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
