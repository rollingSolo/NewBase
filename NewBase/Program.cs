using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Worker("Vasya", "Pupkin",5000,"Sigma");
            Person p2 = new Client("Senya", "Podzalupniy", "Cancer!");

            p1.Show();
            p2.Show();


            
            


            Console.ReadKey();
        }
    }
}
