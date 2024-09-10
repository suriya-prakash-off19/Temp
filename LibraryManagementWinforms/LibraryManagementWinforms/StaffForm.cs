using LibraryManagementWinforms.CommonUserControls;
using LibraryManagementWinforms.StaffUserControls;
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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            PnlOpt.Resize += OptPanelResize;
            Members members = new Members();
            AddPanel(members);
        }

        private void AddPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.Visible = true;
            userControl.Enabled = true;
            try
            {
                Container.Controls[0].Dispose();
            }
            catch
            {

            }
            Container.Controls.Clear();
            Container.Controls.Add(userControl);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void MouseEnter(object sender, EventArgs e)
        {
            PictLabel pict = sender as PictLabel;
            RoundedPanel roundedPanel = pict.Parent as RoundedPanel;
            roundedPanel.BackColor = Color.FromArgb(237, 246, 249);

        }
        private void MouseLeave(object sender, EventArgs e)
        {

            PictLabel pict = sender as PictLabel;
            RoundedPanel roundedPanel = pict.Parent as RoundedPanel;
            roundedPanel.BackColor = Color.FromArgb(174, 197, 235);

        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int width = (int)((this.Width) * 0.16);
            PnlOpt.Width = width;
            int padding = (int)(this.Height * 0.03);
            this.Padding = new Padding(10, padding, padding, padding);
        }

        private void OptPanelResize(object sender, EventArgs e)
        {
            int maxFontSize = 14;
            var panel = ((Panel)sender);
            int panelHeight = (panel).Height;
            int panelWidth = (panel).Width;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is RoundedPanel)
                {
                    var panel1 = c as RoundedPanel;
                    var label = panel1.Controls[0] as PictLabel;
                    int size = maxFontSize + Math.Max(panelHeight / 300, panelWidth / 300);

                    label.LblFont = new Font(c.Font.FontFamily, size);
                }
            }
            int padding = (int)(panel.Width * 0.01);
            panel.Padding = new Padding(padding, 2 * padding, padding, 2 * padding);

        }

        private void LblMember_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            AddPanel(members);
        }

        private void LblBook_Click(object sender, EventArgs e)
        {
            StaffBooks books = new StaffBooks();
            AddPanel(books);
        }

        private void LblProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            AddPanel(profile);
        }

        private void LblLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
