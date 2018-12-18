using System;                                                                                                                                          
namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] f = new Food[6];
            f[0] = new Pizza(55, false, 8, 5);
            f[1] = new Pizza(65, false, 8, 6);
            f[2] = new Pizza(75, false, 8, 7);
            f[3] = new Chips(15,true,true,false);
            f[4] = new Chips(20,false,true,false);
            f[5] = new Chips(25,true,false,true);

            for (int i = 0; i <= 6; i++)
            {
                if (f[i] is Pizza)
                {
                    Console.WriteLine($"Pizza \nPeice:{f[i].Peice}\nIsVeg:{f[i].IsVeg}\n");  //peice:{peice} isVeg:{isVeg} 
                    Console.WriteLine($"{((Pizza)f[i]).GetInfo()}");
                    Console.WriteLine("------------------------------");

                }


                if (f[i] is Chips)
                {
                    Console.WriteLine($"Chips\nPeice:{f[i].Peice}\nIsVeg:{f[i].IsVeg}\n");  //peice:{peice} isVeg:{isVeg} 
                    Console.WriteLine($"{((Chips)f[i]).GetInfo()}");
                    Console.WriteLine("------------------------------");

                }

            }

        }
    }
}
