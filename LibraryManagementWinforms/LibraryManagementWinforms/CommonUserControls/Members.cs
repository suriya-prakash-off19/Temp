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
    public partial class Members : UserControl
    {
        private int position;
        private string search;
        public Members()
        {
            InitializeComponent();
            var members = Search.MemberOnName("");
            var list = MemberOperations.GetAllMembers(members);
            AddData(list);
            position = 0;
            search = "";
            searchBar1.TextChanged += TextChange;
        }

        private void AddData(List<string[]> members)
        {
            dataGridView1.Rows.Clear();
            foreach(var s in members)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            Transparant transparant = new Transparant();
            TempForm tempForm = new TempForm(new AddMember());
            transparant.Show();
            tempForm.ShowDialog();
            tempForm.Dispose();
            tempForm.Close();
            transparant.Close();
            var members = Search.MemberOnName("");
            var list = MemberOperations.GetAllMembers(members);
            AddData(list);
        }

        private void TextChange(object sender,EventArgs e)
        {
            TextBox label = sender as TextBox;
            search = label.Text;
            List<Member> data;
            switch(position)
            {
                case 0:
                    data = Search.MemberOnName(search);
                    break;
                case 1:
                    data = Search.MembersOnId(search);
                    break;
                case 2:
                    data = Search.MembersOnAddress(search);
                    break;
                case 3:
                    data = Search.MembersOnContact(search);
                    break;
                default:
                    data = Search.MembersOnType(search);
                    break;
            }
            AddData(MemberOperations.GetAllMembers(data));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = comboBox1.SelectedIndex;
            TextBox textBox = new TextBox();
            textBox.Text = search;
            TextChange(textBox, EventArgs.Empty);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GridSize();
        }

        private void GridSize()
        {
            if (this.FindForm()?.WindowState == FormWindowState.Maximized)
                dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 18, dataGridView1.Font.Style);
            else
                dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 12, dataGridView1.Font.Style);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                Transparant transparant = new Transparant();
                TempForm tempForm = new TempForm(new AddMember(id));
                transparant.Show();
                tempForm.ShowDialog();
                tempForm.Close();
                transparant.Close();
                var members = Search.MemberOnName("");
                var list = MemberOperations.GetAllMembers(members);
                AddData(list);
            }
            catch
            {

            }
            
        }
    }
}
