using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gorox12._05._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            a:
            Console.WriteLine("Практическая работа №1");
            string c,b;
            int a;
            Console.WriteLine("1 = метод Stpow"+"\n"+"2 = Rev"+"\n"+"3 = Remove"+"\n"+"4 = Leng");
            int S = Convert.ToInt32(Console.ReadLine());
            switch (S)
            {
                case 1:
                    Console.WriteLine("Задание 2" + "\n" + "Введите слово, которое будет повторятся");
                    b = Console.ReadLine();
                    Console.WriteLine("Введите количество повторения слова");
                    a = Convert.ToInt32(Console.ReadLine());
                    lib1.Stpow(b, a);
                    Console.ReadLine();
                    goto a;
                case 2:
                    Console.WriteLine("Введите строку, которую хотите перевернуть");
                    b = Console.ReadLine();
                    lib1.Rev(b);
                    Console.ReadLine();
                    goto a;
                case 3:
                    Console.WriteLine("Введите строку в которой хотите удалить символы");
                    c = Console.ReadLine();
                    Console.WriteLine("Введите символы, которые вы хотите удалить из строки");
                    b = Console.ReadLine();
                    lib1.Remove(c, b);
                    Console.ReadLine();
                    goto a;
                case 4:
                    Console.WriteLine("Введите строку, длинну которого хотите узнать");
                    b = Console.ReadLine();
                    lib1.Leng(b);
                    Console.ReadLine();
                    goto a;
            }

        }
    }
    static class lib1
    {
        public static void Stpow(string a, int b)
        {
            string c = "";
            for (int i = 0; i < b; i++)
            {
                c += a;
            }
            Console.WriteLine("" + c);
        }
        public static void Rev(string a)
        {
            string c = "";
            for (int i = a.Length - 1; i > -1; i--)
            {
                c += a[i];
            }
            Console.WriteLine(""+c);
        }
        public static void Remove(string str, string s)
        {
            string c = "";
            c = str.Replace(s, "");   
            Console.WriteLine(c);
        }
        public static void Leng(string str)
        {
            int a = str.Length;
            Console.WriteLine(a);
        }
    }
}
