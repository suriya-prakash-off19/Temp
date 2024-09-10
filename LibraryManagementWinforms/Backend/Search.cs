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
            var temp = DataManager.members.Values;
            return temp.Where(x => x.Name.ToLower().StartsWith(name.ToLower())).ToList();
        }

        public static Member MemberOnId(string id)
        {
            return DataManager.members[id];
        }

        public static List<Member> MembersOnId(string id)
        {
            return DataManager.members.Values.Where(x=>x.MemberID.StartsWith(id)).ToList();
        }

        public static List<Member> MembersOnType(string type)
        {
            return DataManager.members.Values.Where(x => x.MemberShip.ToString().ToLower().StartsWith(type.ToLower())).ToList();
        }

        public static List<Member> MembersOnContact(string contact)
        {
            return DataManager.members.Values.Where(x => x.Contact.StartsWith(contact)).ToList();
        }

        public static List<Member> MembersOnAddress(string address)
        {
            return DataManager.members.Values.Where(x => x.Address.StartsWith(address)).ToList();
        }

        public static List<Staff> StaffOnName(string name)
        {
            var temp = DataManager.staffs.Values;
            return temp.Where(x => x.Name.ToLower().StartsWith(name.ToLower())).ToList();
        }
        public static List<Staff> StaffOnAddress(string address)
        {
            var temp = DataManager.staffs.Values;
            return temp.Where(x => x.Address.ToLower().StartsWith(address.ToLower())).ToList();
        }

        public static Staff StaffOnId(string id)
        {
            return DataManager.staffs[id];
        }

        public static List<Book> BookOnName(string name)
        {
            var temp = DataManager.books.Values;
            return temp.Where(x => x.Title.StartsWith(name)).ToList();
        }

        public static List<Book> BookOnAuthor(string author)
        {
            var temp = DataManager.books.Values;
            return temp.Where(x => x.Author.ToLower().StartsWith(author.ToLower())).ToList();
        }

        public static Book BookOnISBN(string isbn)
        {
            return DataManager.books[isbn];
        }

        public static List<Book> BooksOnISBN(string isbn)
        {
            return DataManager.books.Values.Where(x => x.ISBN.StartsWith(isbn)).ToList();
        }
    }
}
