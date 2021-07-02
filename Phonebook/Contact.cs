using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook
{
    public class Contact
    {
        public string Name;
        public string PhoneNumber;

        public Contact(string name, string number)
        {
            Name = name;
            PhoneNumber = number;
        }
    }
}
