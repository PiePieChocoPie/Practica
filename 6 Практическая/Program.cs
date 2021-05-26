using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylib;
namespace Практика_6_горох
{
    class Program
    {
        static void Main(string[] args)
        {
        a:
            Console.WriteLine("Choice");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {

                case 1:
                    Console.Clear();
                    student.Prosmotr();
                    Console.ReadLine();
                    goto a;
                case 2:
                    int index = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    string group = Console.ReadLine();
                    string date = Console.ReadLine();
                    student.ADD(index, name, group, date);
                    Console.Clear();
                    goto a;
                case 3:
                    index = Convert.ToInt32(Console.ReadLine());
                    student.Delete(index);
                    Console.Clear();
                    goto a;
                case 4:
                    Console.Clear();
                    student.Fio();
                    Console.ReadLine();
                    goto a;
                case 5:
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    student.PoiskID(index);
                    Console.ReadLine();
                    goto a;
                case 6:
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    student.Years(index);
                    goto a;
            }
        }
    }
}
