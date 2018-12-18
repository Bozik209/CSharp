using System;
namespace ConsoleApp17
{
    class Chips : Food
    {
        private bool isExtraBIG;
        public bool IsExtraBIG
        {
            get { return isExtraBIG; }
            set { isExtraBIG = value; }
        }

        private bool isWhitDipps;
        public bool IsWhitDipps
        {
            get { return isWhitDipps; }
            set { isWhitDipps = value; }
        }

        public Chips(decimal peice, bool isVeg,bool isExtraBIG, bool isWhitDipps) : base(peice, isVeg)
        {
            IsExtraBIG = isExtraBIG;
            IsWhitDipps = isWhitDipps;
        }

        public string GetInfo()
        {
            return $"isExtraBIG:{isExtraBIG} isWhitDipps:{isWhitDipps}";
        }
    }
}
