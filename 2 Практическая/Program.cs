using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Практическая
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string s;
            int F = 0, index = 0;
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'f')
                {
                    F++;
                    if (F == 2)
                    {
                        index += i;
                    }
                }
            }
            if (F > 2)
            {
                Console.WriteLine("Второе вхождения f = " + index);
                Console.WriteLine("Всего f = " + F);
            }
            if (F == 2)
            {
                Console.WriteLine("Второе вхождения f = " + index);
                Console.WriteLine("Всего f = " + F);
            }
            if (F == 1)
            {
                Console.WriteLine(-1);
            }
            if (F == 0)
            {
                Console.WriteLine(-2);
            }
            Console.ReadLine();
            //
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите слово для транслитерации");
            string translit = "";
            string Word = Console.ReadLine();
            char[] rus = { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ы', 'э', 'ю', 'я' };
            string[] eng = { "a", "b", "v", "g", "d", "e", "j", "z", "i", "k", "l", "m", "n", "o", "p", "r", "s", "t", "y", "f", "h", "c", "ch", "sh", "sh", "ie", "e", "ye", "ya" };
            for (int i = 0; i < Word.Length; i++)
            {
                for (int C = 0; C < rus.Length; C++)
                {
                    if (Word[i] == rus[C])
                    {
                        translit += eng[C];
                    }
                }
            }
            Console.WriteLine(translit);
            Console.ReadLine();

            Console.WriteLine("Задание 3. введите строку");
            string str = Console.ReadLine(), otv = "";
            int n = 0, m = 0;
            for (int i = 0; i < str.Length; i++){if (str[i] == 'h') n++;}
            for (int j = 0; j < str.Length; j++){if (str[j] == 'h'){if (m != 0 && m != n - 1) otv += "H";else otv += "h";m++;}else otv += str[j];}
            Console.WriteLine(otv);
            Console.ReadLine();
        }
    }
}
