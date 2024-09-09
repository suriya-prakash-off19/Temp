using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    abstract public class Person
    {
        protected Person(string name,string address,string contact)
        {
            Name = name;
            Address = address;
            Contact = contact;
        }

        public string Name { get; internal set; }
        public string Address { get; internal set; }
        public string Contact { get; internal set; }

    }
}
