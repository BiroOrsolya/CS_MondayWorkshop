using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class TelephoneDirectory
    {
        public List<Person> PersonList;
        public TelephoneDirectory()
        {
            PersonList = new List<Person>(50);
        }

        public void AddPerson(Person person)
        {
            PersonList.Add(person);
        }

        public override string ToString()
        {
            return "People: " + PersonList;
        }
    }
}
