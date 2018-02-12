using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBase
{
    class Worker : Person
    {
        public int Payment { get; set; }
        public string Company { get; set; }

        public Worker(string name, string lastName, int pay, string company) : base(name, lastName)
        {
            Payment = pay;
            Company = company;
        }
        public new void Show()
        {
            Console.WriteLine("Im worker");
        }

        public void Kuku()
        {
            Console.WriteLine("Kuku");
        }

        
    }
}
