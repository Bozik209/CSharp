using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address address1 = new Address();

           // address1.getInfo();

            Person p1 = new Person();
            p1.Name = "bob";
            p1.Person_Address = new Address("ariel", "israel", "ther", 15);

            p1.getInfo();        

        }
    }
}
