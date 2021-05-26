using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2_часть
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masort = new int[10];
            int[,] mass = new int[10,10];
            Random rnd = new Random();
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9;j++)
                {
                    mass[i, j] = rnd.Next(0, 9);
                    Console.Write(mass[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    masort[j] = mass[j, i];
                }
                Array.Sort(masort);
                for (int u = 0; u < 9; u++)
                {
                    mass[u, i] = masort[u];
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(mass[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
