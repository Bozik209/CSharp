using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10._12._18
{
    class cinema
    {
        private string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }

        private int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        private bool kosher;
        public bool Kosher
        {
            get { return kosher; }
            set { kosher = value; }
        }

        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        private int expiration;
        public int Expiration
        {
            get { return  expiration; }
            set{
                if (value>=2018){expiration = value; }
                }
        }


        public cinema(string product,int cost,bool kosher, string manufacturer,int expiration)
        {
            Product = product;
            Cost = cost;
            Kosher = kosher;
            Manufacturer = manufacturer;
            Expiration = expiration;
        }
        public string GetDescription()
        {
            Console.WriteLine("-------------------------");
            string rec = $"product name:{product}\n" +
                $"cost:{cost}\n";
            if (kosher)
                rec += $"kosher: yes\n";
            else
                rec += $"kosher: no\n";
            rec += $"Manufacturer: {manufacturer}\n";
            if (expiration!=0)
                rec += $"expiration: {expiration}\n";
            else
                rec += $"expiration at {expiration}\n";
            return rec;
        }
    }
}
