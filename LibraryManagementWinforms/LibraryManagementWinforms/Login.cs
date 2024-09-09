using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace LibraryManagementWinforms
{
    public partial class Login : Form
    {
        public int index = 1;
        public Login()
        {
            InitializeComponent();
            try
            {
                DataManager.AddData();
            }catch
            {

            }
        }

        private void pictLabel1_Load(object sender, EventArgs e)
        {

        }
        private void LoginMouseEnter(object sender, EventArgs e)
        {
            PictLabel pict = sender as PictLabel;
            RoundedPanel roundedPanel = pict.Parent as RoundedPanel;
            roundedPanel.BackColor = Color.FromArgb(174, 197, 235);

        }
        private void LoginMouseLeave(object sender, EventArgs e)
        {

            PictLabel pict = sender as PictLabel;
            RoundedPanel roundedPanel = pict.Parent as RoundedPanel;
            roundedPanel.BackColor = Color.FromArgb(237, 246, 249);

        }

        private void PanelEnter(object sender, EventArgs e)
        {
            RoundedPanel roundedPanel = sender as RoundedPanel;
            roundedPanel.BackColor = Color.FromArgb(174, 197, 235);

        }

        private void PanelLeave(object sender, EventArgs e)
        {
            RoundedPanel roundedPanel = sender as RoundedPanel;
            roundedPanel.BackColor = Color.FromArgb(237, 246, 249);
        }

        private void Close(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
                if(index==1)
                {
                    Person person = new Staff();
                    StaffForm staffForm = new StaffForm();
                    staffForm.ShowDialog();
                }
                else
                {
                    Person person = new Member();
                    MemberForm memberForm = new MemberForm(person);
                    memberForm.ShowDialog();
                }
            Show();
        }

        private void StaffCilck(object sender, EventArgs e)
        {
            index = 1;
            label2.Text = "Staff Login";
            label3.Text = "Staff ID";
        }

        private void MemberClick(object sender, EventArgs e)
        {
            index = 2;
            label2.Text = "Member Login";
            label3.Text = "Member ID";
        }
    }
}
