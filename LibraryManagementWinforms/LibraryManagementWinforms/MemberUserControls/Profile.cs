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
    public partial class Profile : UserControl
    {
        private static Profile profile;
        private static int index = -1;
        public Profile(int id)
        {
            InitializeComponent();
            index = id;
            SetData();
            AddContent();
        }

        private void SetData()
        {
            Member member = Search.MemberOnId(index.ToString());
            LblId.Text = member.MemberID;
            LblName.Text = member.Name;
            LblPassword.Text = member.Password;
            LblType.Text = member.MemberShip.ToString();
            LblContact.Text = member.Contact;
            LblAddress.Text = member.Address;
        }

        private void AddContent()
        {
            foreach(var x in MemberOperations.GetDataForBorrowedBooks(index))
            {
                dataGridView1.Rows.Add(x);
            }
        }

        public static Profile GetInstance(int id)
        {
            if(id!=index || profile==null)
            {
                if (profile != null)
                    profile.Dispose();
                profile = new Profile(id);
            }
            return profile;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
