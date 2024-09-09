using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public static class Search
    {
        public static List<Member> MemberOnName(string name)
        {
            var temp = DataManager.members.Values.ToList();
            return temp.Where(x => x.Name.StartsWith(name)).ToList();
        }

        public static List<Member> MemberOnId(string id)
        {
            var temp = DataManager.members.Values.ToList();
            return temp.Where(x => x.MemberID.StartsWith(id)).ToList();
        }

        public static List<Staff> StaffOnName(string name)
        {
            var temp = DataManager.staffs.Values.ToList();
            return temp.Where(x => x.Name.StartsWith(name)).ToList();
        }

        public static List<Staff> StaffOnId(string id)
        {
            var temp = DataManager.staffs.Values.ToList();
            return temp.Where(x => x.StaffId.StartsWith(id)).ToList();
        }

        public static List<Book> BookOnName(string name)
        {
            var temp = DataManager.books.Values.ToList();
            return temp.Where(x => x.Title.StartsWith(name)).ToList();
        }

        public static List<Book> BookOnAuthor(string author)
        {
            var temp = DataManager.books.Values.ToList();
            return temp.Where(x => x.Author.StartsWith(author)).ToList();
        }

        public static List<Book> BookOnISBN(string isbn)
        {
            var temp = DataManager.books.Values.ToList();
            return temp.Where(x => x.ISBN.StartsWith(isbn)).ToList();
        }

        public static List<Book> BookOnBorrowed(string id)
        {
            return DataManager.BorrowedBooks[id].Select(x => x.book).ToList();
        }
    }
}
