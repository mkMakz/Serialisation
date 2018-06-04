using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Classes.LIB.Modules
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string TellephoneNumber { get; set; }
        public string DateOfBirth { get; set; }

        [NonSerialized]
        public List<Person> person = new List<Person>();

        public Person[] persons;
        public void FilPerson()
        {
            persons = person.ToArray();
        }
    }
}
