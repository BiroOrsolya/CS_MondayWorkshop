using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string TelephoneNumber { get; set; }
        public string Type;
        public Person(string name, string address, int age, string telephone, string type)
        {
            Name = name;
            Address = address;
            Age = age;
            TelephoneNumber = telephone;
            Type = type;
        }

        public override string ToString()
        {
            return "Name: " + Name + "Address: " + Address + "Age: " + Age + " " + Type + ": " + TelephoneNumber;
        }
    }
}
