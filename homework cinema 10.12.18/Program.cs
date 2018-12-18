using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10._12._18
{
    class Program
    {
        static void Main(string[] args)
        {
            cinema[] cinemaFood=new cinema[5];
            cinemaFood[0] = new cinema("pop", 15, true, "osem", 2018);
            cinemaFood[1] = new cinema("chocolate", 10, true, "para", 2017);
            cinemaFood[2] = new cinema("hamburger", 150, false, "bbb", 2018);
            cinemaFood[3] = new cinema("Fries", 30, true, "doritos", 2018);
            cinemaFood[4] = new cinema("cola", 15, true, "cocacola", 2018);


            for (int i = 0; i < cinemaFood.Length; i++)
            {
            Console.WriteLine(cinemaFood[i].GetDescription());
            }
        }
    }
}
