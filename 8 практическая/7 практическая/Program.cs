﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_практическая
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[10, 10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass[i,j] += rnd.Next(0, 10);
                    Console.Write(mass[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            int o = 0;
            long sum = mass[0,0];
            for (int i = 0; i < 10; i++)
            {
                if (sum < mass[i,o])
                {
                    sum = mass[i,o];
                }
                o++;
            }
            int u = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mass[i, u] == sum)
                {
                    Console.WriteLine(mass[i,u]);
                    Console.WriteLine("Максимальный элемент главной диагонали находится по координатам = " + "{" + i + ";" + u + "}");
                    break;
                }
                u++;
            }
            int g = 0;
            long SUM = mass[0, 9];
            for (int i = 9; i > 0; i--)
            {
                if (SUM < mass[g, i])
                {
                    SUM = mass[g, i];
                }
                g++;
            }
            int k = 0;
            for (int i = 9; i > 0; i--)
            {
                if (mass[k,i] == SUM)
                {
                    Console.WriteLine(SUM);
                    Console.WriteLine("Максимальный элемент побочной диагонали находится по координатам = " + "{" + k+ ";" + i + "}");
                    break;
                }
                k++;
            }
            Console.ReadLine();
            int b = 0;
            int summa = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    summa += mass[j, i];
                }
                Console.WriteLine("Сумма столбца = " + summa);
                summa = 0;
            }
            Console.ReadLine();
        }
    }
}
