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
            dataGridView1.Rows.Clear();
            foreach (var x in MemberOperations.GetDataForBorrowedBooks(index))
            {
                dataGridView1.Rows.Add(x);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var s =dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                DialogResult dialogResult = MessageBox.Show("Are you sure want to return the book?", "Confirmation", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    MemberOperations.ReturnBook((string)s, index.ToString());
                }
            }
            catch
            {

            }

            AddContent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempForm tempForm = new TempForm(new EditProfile(index));
            Transparant transparant = new Transparant();
            transparant.Show();
            tempForm.ShowDialog();
            transparant.Close();
            tempForm.Close();
            SetData();
        }
        private void LabelResize(object sender, EventArgs e)
        {
            //Label label = (Label)sender;
            //if (this.FindForm()?.WindowState == FormWindowState.Maximized)
            //{
            //label.Font = new Font(label.Font.FontFamily, 18, label.Font.Style);
            //}
            //else
            //{
            //if (label.Parent != null)
            //    label.Font = new Font(label.Font.FontFamily, 14, label.Font.Style);
            //}
            //label.Dock = DockStyle.Fill;
        }
        
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            foreach(var x in tableLayoutPanel1.Controls)
            {
                if(x is Label || x is Button)
                {
                    Control label = x as Control;
                    if (this.FindForm()?.WindowState == FormWindowState.Maximized)
                    {
                        label.Font = new Font(label.Font.FontFamily, 18, label.Font.Style);
                    }
                    else
                    {
                        label.Font = new Font(label.Font.FontFamily, 14, label.Font.Style);
                    }
                    label.Dock = DockStyle.Fill;
                }
            }
            BtnSize();
            GridSize();

        }

        private void GridSize()
        {
            if (this.FindForm()?.WindowState == FormWindowState.Maximized)
                dataGridView1.Font= new Font(dataGridView1.Font.FontFamily, 18, dataGridView1.Font.Style);
            else
                dataGridView1.Font= new Font(dataGridView1.Font.FontFamily, 14, dataGridView1.Font.Style);
        }

        private void BtnSize()
        {
            if (this.FindForm()?.WindowState == FormWindowState.Maximized)
            {
                EdtProd.Font = new Font(EdtProd.Font.FontFamily, 18, EdtProd.Font.Style);
                EdtProd.Height = 40;
            }
            else
            {
                EdtProd.Font = new Font(EdtProd.Font.FontFamily, 14, EdtProd.Font.Style);
                EdtProd.Height = 30;
            }
        }
    }
}
