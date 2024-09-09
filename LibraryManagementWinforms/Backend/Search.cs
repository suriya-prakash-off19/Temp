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

        public static Member MemberOnId(string id)
        {
            return DataManager.members[id];
        }

        public static List<Staff> StaffOnName(string name)
        {
            var temp = DataManager.staffs.Values.ToList();
            return temp.Where(x => x.Name.StartsWith(name)).ToList();
        }

        public static Staff StaffOnId(string id)
        {
            return DataManager.staffs[id];
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

        public static Book BookOnISBN(string isbn)
        {
            return DataManager.books[isbn];
        }
    }
}
