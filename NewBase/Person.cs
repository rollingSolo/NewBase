using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBase
{
     class Person
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public virtual void Show()
        {
            Console.WriteLine("im a Person");
        }
    }
}
