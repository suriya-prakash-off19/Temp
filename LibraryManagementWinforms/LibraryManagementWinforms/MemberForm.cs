using Backend;
using LibraryManagementWinforms.MemberUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementWinforms
{
    public partial class MemberForm : Form
    {
        
        private Member Member;
        public MemberForm(Person person)
        {
            InitializeComponent();
            PnlOpt.Resize += OptPanelResize;
            DoubleBuffered = true;
            ResizeRedraw = true;
            Member = person as Member;
            Books books = Books.GetInstance(Convert.ToInt32(Member.MemberID));
            PnlCont.Controls.Clear();
            PnlCont.Controls.Add(books);
            books.Dock = DockStyle.Fill;
            books.BringToFront();
            books.Visible = true;
            books.Enabled = true;
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
        private void MouseEnter(object sender,EventArgs e)
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
            int width =(int)( (this.Width) * 0.16);
            PnlOpt.Width = width;
            int padding = (int)(this.Height * 0.03);
            this.Padding = new Padding(10, padding, padding, padding);
        }

        private void OptPanelResize(object sender,EventArgs e)
        {
            int maxFontSize = 14;
            var panel = ((Panel)sender);
            int panelHeight = (panel).Height;
            int panelWidth = (panel).Width;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if(c is RoundedPanel)
                {
                    var panel1 = c as RoundedPanel;
                    var label = panel1.Controls[0] as PictLabel;
                    int size = maxFontSize + Math.Max(panelHeight / 300, panelWidth / 300);

                    label.LblFont = new Font(c.Font.FontFamily, size);
                }
            }
            int padding = (int)(panel.Width * 0.01);
            panel.Padding = new Padding(padding,2*padding,padding,2*padding);

        }



        private void ProfileClick(object sender, EventArgs e)
        {
            Profile profile = new Profile(Convert.ToInt32(Member.MemberID));
            PnlCont.Controls.Clear();
            PnlCont.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.BringToFront();
            profile.Visible = true;
            profile.Enabled = true;
        }

        private void BooksClick(object sender, EventArgs e)
        {
            Books books =new Books(Convert.ToInt32(Member.MemberID));
            PnlCont.Controls.Clear();
            PnlCont.Controls.Add(books);
            books.Dock = DockStyle.Fill;
            books.BringToFront();
            books.Visible = true;
            books.Enabled = true;

        }

        private void Logout(object sender, EventArgs e)
        {

            Close();
        }
    }
}
