using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public static class DataManager
    {
        public static Dictionary<string, Member> members = new Dictionary<string, Member>();
        public static Dictionary<string, Staff> staffs = new Dictionary<string, Staff>();
        public static Dictionary<string, Book> books = new Dictionary<string, Book>();
        public static Dictionary<string, List<(Book book,DateTime date)>> BorrowedBooks = new Dictionary<string, List<(Book book, DateTime date)>>();
        public static int StaffId { get; internal set; }
        public static int MemberId { get; internal set; }

    }
    public static class MemberOperations
    {
        public static void AddMember(string name,string address,string contact,string password, MemberShip memberShip)
        {
            var id = DataManager.MemberId.ToString();
            Member member = new Member(name, address, contact,password, id, memberShip);
            DataManager.members.Add(id,member);
            DataManager.BorrowedBooks.Add(id, new List<(Book book, DateTime date)>());
            DataManager.MemberId++;
        }

        public static void RemoveMember(string id)
        {
            DataManager.members.Remove(id);
        }

        public static void BorrowBook(string isbn,string id)
        {
            var b = DataManager.books[isbn];
            b.Borrow();
            DataManager.BorrowedBooks[id].Add((b,DateTime.Now));
        }

        public static void ReturnBook(string isbn,string id)
        {
            var book = DataManager.books[isbn];
            if (DataManager.BorrowedBooks.Remove(id))
                book.ReturnItem();
            
        }

        public static void ChangeData(string name,string address,string contact,string password,string id,MemberShip memberShip)
        {
            var member = DataManager.members[id];
            member.Name = name;
            member.Address = address;
            member.Contact = contact;
            member.MemberShip = memberShip;
            member.Password = password;
        }
    }

    public static class BookOperations
    {
        public static void AddBook(string title,string author,string isbn,bool availability=true,int noOfItems=1)
        {
            Book book = new Book(title, author, isbn, availability, noOfItems);
            DataManager.books.Add(isbn, book);
        }
        public static void RemoveBook(string id)
        {
            DataManager.books.Remove(id);
        }

        public static Book GetDetails(string id)
        {
            return DataManager.books[id];
        }

        public static void ChangeData(string title,string author,string isbn,bool avail,int noOfItems )
        {
            var book = DataManager.books[isbn];
            book.Title = title;
            book.Author = author;
            book.Availability = avail;
            book.NoOfitems = noOfItems;
        }
    }

    public static class StaffOperations
    {
        public static void AddStaff(string name,string address,string contact,string password,StaffPosition staffPosition)
        {
            var id = DataManager.StaffId.ToString();
            Staff staff = new Staff(name, address, contact, password, id, staffPosition);
            DataManager.staffs.Add(id, staff);
        }

        public static void RemoveStaff(string id)
        {
            DataManager.staffs.Remove(id);
        }

        public static void ChangeData(string name, string address, string contact, string password, StaffPosition staffPosition,string id)
        {
            var staff = DataManager.staffs[id];
            staff.Name = name;
            staff.Address = address;
            staff.Contact = contact;
            staff.Password = password;
            staff.StaffPosition = staffPosition;
        }
    }
    
}
