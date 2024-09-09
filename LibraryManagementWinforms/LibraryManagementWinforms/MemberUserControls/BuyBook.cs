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
    public partial class BuyBook : UserControl
    {
        private Book book;
        private int id;
        public BuyBook(string ISBN,int id)
        {
            InitializeComponent();
            book = Search.BookOnISBN(ISBN);
            this.id = id;
            SetValue();
        }

        private void SetValue()
        {
            LblAuthor.Text = book.Author;
            LblAvail.Text = book.Availability.ToString();
            LblNOI.Text = book.NoOfitems.ToString();
            LblName.Text = book.Title;
            LblISBN.Text = book.ISBN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book.Borrow();
            DataManager.BorrowedBooks[id.ToString()].Add((book, DateTime.Now));
            FindForm()?.Close();
        }
    }
}
