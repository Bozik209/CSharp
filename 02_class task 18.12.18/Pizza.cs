using System;
namespace ConsoleApp17
{
    class Pizza : Food
    {
        private int numOfSlices;
        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }

        private int numOfTopping;
        public int NumOfTopping
        {
            get { return numOfTopping; }
            set { numOfTopping = value; }
        }

        public Pizza(decimal peice, bool isVeg,int numOfSlices, int numOfTopping) : base(peice, isVeg)
        {
            NumOfSlices = numOfSlices;
            NumOfTopping = numOfTopping;
        }

        public string GetInfo()
        {
            return $"numOfSlices:{numOfSlices} numOfTopping:{numOfTopping}";
        }


    }
}
