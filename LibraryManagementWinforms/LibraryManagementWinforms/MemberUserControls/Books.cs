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
    public partial class Books : UserControl
    {
        private static Books books;
        private static int index = -1;
        private int Position;
        private string Check;
        public Books(int id)
        {
            InitializeComponent();
            index = id;
            var books = Search.BookOnName("");
            var result = BookOperations.GetDataForAllBooks(books);
            AddBooks(result);
            searchBar1.TextChanged += TextChangedHandler;
            Position = 0;
            Check = "";
        }

        private void AddBooks(List<string[]> list)
        {

            dataGridView1.Rows.Clear();
            foreach (var book in list)
            {
                dataGridView1.Rows.Add(book);
            }
        }

        public static Books GetInstance(int id)
        {
            if (books == null || index != id)
            {
                if (books != null)
                    books.Dispose();
                books = new Books(id);
                
            }
            return books;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var x = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                Transparant transparant = new Transparant();
                transparant.Show();
                BuyBook buyBook = new BuyBook(x.ToString(), index);
                TempForm tempForm = new TempForm(buyBook);
                tempForm.ShowDialog();
                transparant.Close();
            }
            catch(Exception el)
            {
                MessageBox.Show(el.Message);
            }
            var books = Search.BookOnName("");
            var result = BookOperations.GetDataForAllBooks(books);
            AddBooks(result);
        }
        private void TextChangedHandler(object sender,EventArgs e)
        {
            Check = ((TextBox)sender).Text;
            List<Book> book;
            switch(Position)
            {
                case 0:
                    book = Search.BookOnName(Check);
                    break;
                case 1:
                    book = Search.BookOnAuthor(Check);
                    break;
                default:
                    book = Search.BooksOnISBN(Check);
                    break;
            }
            var y = BookOperations.GetDataForAllBooks(book);
            AddBooks(y);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Position = comboBox1.SelectedIndex;
            TextBox textBox = new TextBox();
            textBox.Text = Check;
            TextChangedHandler(textBox, EventArgs.Empty);
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
                dataGridView1.Font = new Font(dataGridView1.Font.FontFamily, 14, dataGridView1.Font.Style);
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
   }
}
