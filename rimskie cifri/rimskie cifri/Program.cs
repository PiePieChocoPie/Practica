using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rimskie_cifri
{
    class Program
    {
        static void Main(string[] args)
        {
            a: 
            int S = 0;
            Console.WriteLine("Введите число на проверку палиндромности числу 1.999999999");
            int s = Convert.ToInt32(Console.ReadLine());
            string f = Convert.ToString(s);
            char[] sam = f.ToCharArray();
            Array.Reverse(sam);
            string g = new string(sam);
            int d = f.CompareTo(g);

            if (d == 0)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
            string vvod = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < vvod.Length; i++)
            {
                if (vvod[i] != 'M' || vvod[i] != 'D' || vvod[i] != 'C' || vvod[i] != 'L' || vvod[i] != 'X' || vvod[i] != 'V' || vvod[i] != 'I')
                {
                    Console.WriteLine("Вы ввели недопустимый символ");
                    break;
                }
                if (vvod[i] == 'M')
                {
                    S += 1000;
                }
                if (vvod[i] == 'D')
                {
                    S += 500;
                }
                if (vvod[i] == 'C')
                {
                    S += 100;
                }
                if (vvod[i] == 'L')
                {
                    S += 50;
                }
                if (vvod[i] == 'X')
                {
                    S += 10;
                }
                if (vvod[i] == 'V')
                {
                    S += 5;
                }
                if (vvod[i] == 'I')
                {
                    S += 1;
                }
            }
            if (S > 0)
            {
                Console.WriteLine(S);
            }
            Console.ReadLine();
            goto a;
        }
    }
}
