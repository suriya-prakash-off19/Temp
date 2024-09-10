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
namespace LibraryManagementWinforms.CommonUserControls
{
    public partial class AddMember : UserControl
    {
        private int index;
        private string ID;
        public AddMember()
        {
            InitializeComponent();
            index = 0;
        }
        public AddMember(string id)
        {
            InitializeComponent();
            BtnRemove.Visible = true;
            index = 1;
            var member = Search.MemberOnId(id);
            AddData(member);
            ID = id;
        }

        private void AddData(Member member)
        {
            TxtName.Text = member.Name;
            TxtAddress.Text = member.Address;
            TxtContact.Text = member.Contact;
            TxtPassword.Text = TxtConPassword.Text = member.Password;
            CmbType.SelectedIndex= CmbType.Items.IndexOf(member.MemberShip.ToString());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MemberShip member = (MemberShip)(Enum.Parse(typeof(MemberShip), CmbType.Text));
            if(index==1)
            {
                MemberOperations.ChangeData(TxtName.Text, TxtAddress.Text, TxtContact.Text, TxtPassword.Text, ID, member);
            }
            else
            {
                MemberOperations.AddMember(TxtName.Text, TxtAddress.Text, TxtContact.Text, TxtPassword.Text, member);
            }
            this.FindForm()?.Close();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            MemberOperations.RemoveMember(ID);
            this.FindForm()?.Close();
        }
    }
}
