using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public enum MemberShip
    {
        Basic=1,
        Pro,
        Premium
    }
    public class Member : Person
    {
        public Member(string name,string address,string contact,string password,string memberId,MemberShip memberShip):base(name,address,contact)
        {
            MemberID = memberId;
            MemberShip = memberShip;
            Password = password;
        }
        public string Password { get; internal set; }
        public MemberShip MemberShip { get; internal set; }
        public string MemberID { get; internal set; }
    }
}
