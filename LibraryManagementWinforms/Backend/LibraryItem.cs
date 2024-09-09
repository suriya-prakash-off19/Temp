using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public abstract class LibraryItem
    {
        protected LibraryItem(bool availability,int noOfItems)
        {
            Availability = availability;
            NoOfitems = noOfItems;
        }

        public bool Availability { get; internal set; }
        public int NoOfitems { get; internal set; }

        public abstract bool Borrow();
        public abstract void ReturnItem();

        public bool CheckAvailability()
        {
            return Availability;
        }

        public void UpdateAvailability(int noOfItems)
        {
            NoOfitems += noOfItems;
        }

        public void UpdateAvailability(bool availability)
        {
            if (!availability)
                Availability = availability;
            else
                Availability = NoOfitems > 0;
        }

    }
}
