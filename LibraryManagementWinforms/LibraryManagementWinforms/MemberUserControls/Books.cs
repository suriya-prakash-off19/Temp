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
        public Books(int id)
        {
            InitializeComponent();
            index = id;
            AddBooks();
        }

        private void AddBooks()
        {
            var books = Search.BookOnName("");
            foreach(var book in BookOperations.GetDataForAllBooks(books))
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
    }
}
