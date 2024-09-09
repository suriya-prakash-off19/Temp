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
            DataManager.AddData();
            InitializeComponent();
            index = id;
            AddContent();
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
                profile = new Profile(index);
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
