using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public enum StaffPosition
    {
        LibraryAssistant=1,
        Librarian,
        SeniorLibrarian,
    }
    public class Staff : Person
    {
        public Staff(string name,string address,string contact,string password,string staffId,StaffPosition staffPosition):base(name,address,contact)
        {
            StaffId = staffId;
            StaffPosition = staffPosition;
            Password = password;
        }
        public string Password { get; internal set; }
        public string StaffId { get; internal set; }
        public StaffPosition StaffPosition { get; internal set; }
    }
}
