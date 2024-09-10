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
        public static int StaffId { get; internal set; } = 1;
        public static int MemberId { get; internal set; } = 1;
        public static void AddData()
        {
            BorrowedBooks["0"] = new List<(Book book, DateTime date)>();
            //BorrowedBooks["0"].Add((new Book("c#", "John", "1234567890123", true, 10), DateTime.Now));
            //BorrowedBooks["0"].Add((new Book("c#", "John", "1234567890123", true, 10), DateTime.Now));
            //BorrowedBooks["0"].Add((new Book("c#", "John", "1234567890123", true, 10), DateTime.Now));
            //BorrowedBooks["0"].Add((new Book("c#", "John", "1234567890123", true, 10), DateTime.Now));
            //BorrowedBooks["0"].Add((new Book("c#", "John", "1234567890123", true, 10), DateTime.Now));
            //BorrowedBooks["0"].Add((new Book("c#", "John", "1234567890123", true, 10), DateTime.Now));
            members.Add("0", new Member("Suriya", "Palladam", "9384793639", "Suriya6231@", "0", MemberShip.Basic));
            books.Add("1234567890123", new Book("c#1", "John", "1234567890123", true, 10));
            books.Add("123456789012", new Book("c#2", "John", "123456789012", true, 10));
            books.Add("12345678901", new Book("c#3", "John", "12345678901", true, 10));
            books.Add("1234567890", new Book("c#4", "John", "1234567890", true, 10));
            books.Add("123456789", new Book("c#5", "John", "123456789", true, 10));


        }
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
            var x = DataManager.BorrowedBooks[id].FindIndex(y => (y.book.ISBN == isbn));
            DataManager.BorrowedBooks[id].RemoveAt(x);
            book.ReturnItem();
            
        }

        public static List<string[]> GetDataForBorrowedBooks(int id)
        {
            List<string[]> data = new List<string[]>();
            int i = 1;
            foreach(var x in DataManager.BorrowedBooks[id.ToString()])
            {
                Book book = x.book;
                DateTime dateTime = x.date;
                string[] arr = new string[] { i.ToString(),book.ISBN, book.Title, dateTime.ToString("dd/MM/yyyy"), Fine.FineForBook(dateTime).ToString() };
                data.Add(arr);
                i++;
            }
            return data;
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
        public static void ChangeData(string name, string address, string contact, string password, string id)
        {
            var member = DataManager.members[id];
            member.Name = name;
            member.Address = address;
            member.Contact = contact;
            member.Password = password;
        }

        public static List<string[]> GetAllMembers(List<Member> list)
        {
            List<string[]> data = new List<string[]>();
            int n = 1;
            foreach(Member m in list)
            {
                string[] store = new string[] { n.ToString(), m.Name, m.MemberID, m.Address, m.Contact, m.MemberShip.ToString() };
                data.Add(store);
                n++;
            }
            return data;
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

        public static List<string[]> GetDataForAllBooks(List<Book> books)
        {
            List<string[]> arr = new List<string[]>();
            int n = 1;
            foreach(var x in books)
            {
                string[] str = new string[] {n.ToString(), x.Title, x.Author, x.ISBN, x.Availability.ToString(), x.NoOfitems.ToString() };
                arr.Add(str);
                n++;
            }
            return arr;
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
