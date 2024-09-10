using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
namespace LibraryManagementWinforms.MemberUserControls
{
    public partial class EditProfile : UserControl
    {
        private Member Member; 
        public EditProfile(int id)
        {
            InitializeComponent();
            Member = Search.MemberOnId(id.ToString());
            SetData();
        }

        private void SetData()
        {
            TxtName.Text = Member.Name;
            TxtAddress.Text = Member.Address;
            TxtContact.Text = Member.Contact;
            TxtPassword.Text = Member.Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemberOperations.ChangeData(TxtName.Text, TxtAddress.Text, TxtContact.Text, TxtPassword.Text, Member.MemberID);
            this.FindForm()?.Close();
        }
    }
}
