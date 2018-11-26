using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Person
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        private Address person_Address;
        public Address Person_Address
        {
            get { return person_Address; }
            set { person_Address = value; }
        }

        public Person(string name,Address person_Address)
        {
            Name = name;
            Person_Address = person_Address;
        }

        public Person(){
        }


        public void getInfo()
        {
            string res=$" City {person_Address.City}\n Country {person_Address.Country}\n Street {person_Address.Street}\n Number {person_Address.Number}\n";
            Console.WriteLine($" name={name} \n address:\n{res}");
        }
    }
}
