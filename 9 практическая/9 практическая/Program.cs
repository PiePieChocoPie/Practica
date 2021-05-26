using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_практическая
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[8, 8];
            int a = 1,h = -1;
            for (int i = 0; i < 8; i++){for (int j = 0; j < 8; j++) {h *= a * -1;mass[i, j] = h;if (mass[i,j] < 0){mass[i, j] = 0;}Console.Write(mass[i, j] + " ");}Console.WriteLine();h *= a * -1;}
            Console.ReadLine();
            int[,] massiv = new int[10, 10];
            Random rnd = new Random();
            int sum = 0;
            for (int i =0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    massiv[i, j] = rnd.Next(0, 10);
                    sum += massiv[i, j];
                    Console.Write(massiv[i,j] + " ");
                }
                Console.WriteLine("Сумма строки = "+sum);
                sum = 0;
            }
            Console.ReadLine();
            string r = "";
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if ((mass[i,j] % 2 != 0) && (mass[i,j] %3 != 0))
                    {
                        r += mass[i, j];
                    }
                }
            }
            r = new string(r.Distinct().ToArray());
            Console.WriteLine("Уникальные числа = "+ r );
            Console.ReadLine();
        }
    }
}
