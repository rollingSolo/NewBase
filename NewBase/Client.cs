using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBase
{
    class Client:Person
    {
        public Client(string name, string lastName, string issue):base(name, lastName)
        {
            Issue = issue;
        }

        public string Issue { get; set; }


        public override void Show()
        {
            Console.WriteLine("im a Client");
        }

        public void Kuku()
        {
            Console.WriteLine("kuku client");
        }

        
    }
}
