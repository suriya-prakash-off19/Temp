using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Sort
    {
        //Sort based on name of Member
        public static void SortOnName(List<Member> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.Name.CompareTo(a.Name));
            }
            else
            {
                list.Sort((a, b) => a.Name.CompareTo(b.Name));
            }
        }

        //Sort based on name of Staff
        public static void SortOnName(List<Staff> list, bool descending = false)
        {
            if (descending)
            {
                list.Sort((a, b) => b.Name.CompareTo(a.Name));
            }
            else
            {
                list.Sort((a, b) => a.Name.CompareTo(b.Name));
            }
        }

        //Sort based on name of Book
        public static void SortOnName(List<Book> list, bool descending = false)
        {
            if (descending)
            {
                list.Sort((a, b) => b.Title.CompareTo(a.Title));
            }
            else
            {
                list.Sort((a, b) => a.Title.CompareTo(b.Title));
            }
        }

        //Sort based on Id of Member
        public static void SortOnId(List<Member> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => Convert.ToInt32(a.MemberID).CompareTo(Convert.ToInt32(b.MemberID)));
            }
            else
            {
                list.Sort((a, b) => Convert.ToInt32(b.MemberID).CompareTo(Convert.ToInt32(a.MemberID)));
            }
        }

        //Sort based on Id of Staff
        public static void SortOnId(List<Staff> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => Convert.ToInt32(a.StaffId).CompareTo(Convert.ToInt32(b.StaffId)));
            }
            else
            {
                list.Sort((a, b) => Convert.ToInt32(b.StaffId).CompareTo(Convert.ToInt32(a.StaffId)));
            }
        }

        //Sort based on ISBN of Book
        public static void SortOnISBN(List<Book> list, bool descending = false)
        {
            if (descending)
            {
                list.Sort((a, b) => b.ISBN.CompareTo(a.ISBN));
            }
            else
            {
                list.Sort((a, b) => a.ISBN.CompareTo(b.ISBN));
            }
        }

        //Sort based on Contact of Member
        public static void SortOnContact(List<Member> list,bool desceding=false)
        {
            if(desceding)
            {
                list.Sort((a, b) => b.Contact.CompareTo(a.Contact));
            }
            else
            {
                list.Sort((a, b) => a.Contact.CompareTo(b.Contact));
            }
        }

        //Sort based on Contact of Staff
        public static void SortOnContact(List<Staff> list,bool desceding=false)
        {
            if(desceding)
            {
                list.Sort((a, b) => b.Contact.CompareTo(a.Contact));
            }
            else
            {
                list.Sort((a, b) => a.Contact.CompareTo(b.Contact));
            }
        }

        //Sort based on Membership of Member
        public static void SortOnMemberShip(List<Member> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.MemberShip.CompareTo(a.MemberShip));
            }
            else
            {
                list.Sort((a, b) => a.MemberShip.CompareTo(b.MemberShip));
            }
        }

        //Sort based on Position of Staff
        public static void SortOnPostion(List<Staff> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.StaffPosition.CompareTo(a.StaffPosition));
            }
            else
            {
                list.Sort((a, b) => a.StaffPosition.CompareTo(b.StaffPosition));
            }
        }

        //Sort based on Address of Staff
        public static void SortOnAddress(List<Staff> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.Address.CompareTo(a.Address));
            }
            else
            {
                list.Sort((a, b) => a.Address.CompareTo(b.Address));
            }
        }

        //Sort based on Address of Member
        public static void SortOnAddress(List<Member> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.Address.CompareTo(a.Address));
            }
            else
            {
                list.Sort((a, b) => a.Address.CompareTo(b.Address));
            }
        }

        //Sort based on Author of Book
        public static void SortOnAuthor(List<Book> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.Author.CompareTo(a.Author));
            }
            else
            {
                list.Sort((a, b) => a.Author.CompareTo(b.Author));
            }
        }

        //Sort based on NoOfItems of Book

        public static void SortOnNoOfItems(List<Book> list,bool descending=false)
        {
            if(descending)
            {
                list.Sort((a, b) => b.NoOfitems.CompareTo(a.NoOfitems));
            }
            else
            {
                list.Sort((a, b) => a.NoOfitems.CompareTo(b.NoOfitems));
            }
        }

    }
}
