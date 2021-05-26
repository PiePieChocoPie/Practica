using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 Практическая" + "\n" + "1 Задание");
            int[] number = { 10, -3, -5, 2, 5 };
            int min = number[0];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < 0)
                    number[i] *= -1;
                if (min > number[i])
                    min = number[i];
            }
            Console.WriteLine(min);
            Console.ReadLine();
            //2ex
            Console.WriteLine("2 Задание\n");
            int[] numbers = { 1, 5, 2, 1, 2, 3 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Array.Clear(numbers, i, 1);
                        Array.Clear(numbers, j, 1);
                    }
                }
            }
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            //3x
            Console.WriteLine("3 Задание");
            Random rnd = new Random();
            int[] mass = new int[20];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-100, 100);
            }
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    Array.Clear(mass, i, 1);
                }
            }
            foreach(var i in mass)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
