using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Book : LibraryItem
    {
        public Book(string title,string author,string isbn,bool availability,int noOfItems):base(availability,noOfItems)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public string Title { get; internal set; }
        public string Author { get; internal set; }
        public string ISBN { get; internal set; }

        public override bool Borrow()
        {
            if(NoOfitems>0)
            {
                NoOfitems -= 1;
                Availability = NoOfitems > 0;
                return true;
            }
            return false;
        }

        public override void ReturnItem()
        {
            NoOfitems += 1;
            Availability = true;
        }
    }
}
