using System;
namespace ConsoleApp17
{
    class Food
    {
        private decimal peice;
        public decimal Peice
        {
            get { return peice; }
            set { peice = value; }
        }

        private bool isVeg;
        public bool IsVeg
        {
            get { return isVeg; }
            set { isVeg = value; }
        }

        public Food(decimal peice, bool isVeg)
        {
            Peice = peice;
            IsVeg = isVeg;
        }


    }
}
