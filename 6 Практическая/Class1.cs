using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Mylib
{
    class student
    {
        public static ArrayList paramtr = new ArrayList() { 473, "Горохов Александр Иванович", "ИСИП 20-11-1", "20.04.2002" };
        public static void Prosmotr()
        {
            for (int i = 0; i < paramtr.Count - 3; i += 4)
            {
                Console.WriteLine("Индекс студента: " + paramtr[i] + "\nФИО студента: " + paramtr[i + 1] + "\nГруппа студента: " + paramtr[i + 2] + "\nДата рождения студента: " + paramtr[i + 3] + "\n");
            }
        }
        public static void ADD(int index, string name, string group, string date)
        {
            paramtr.Add(index);
            paramtr.Add(name);
            paramtr.Add(group);
            paramtr.Add(date);
        }
        public static void Delete(int index)
        {
            for (int i = 0; i < paramtr.Count - 2; i++)
            {
                if (paramtr[i].ToString().Equals(index.ToString()))
                {
                    paramtr.RemoveAt(i + 3);
                    paramtr.RemoveAt(i + 2);
                    paramtr.RemoveAt(i + 1);
                    paramtr.RemoveAt(i);
                    break;
                }
            }
        }
        public static void Fio()
        {
            for (int i = 1; i < paramtr.Count - 2; i += 4)
            {
                Console.WriteLine("ФИО студента: " + paramtr[i] + "\n");
            }
        }
        public static void PoiskID(int index)
        {
            for (int i = 0; i < paramtr.Count - 3; i += 4)
            {
                if (paramtr[i].ToString().Equals(index.ToString()))
                {
                    Console.WriteLine("Индекс студента: " + paramtr[i] + "\nФИО студента: " + paramtr[i + 1] + "\nГруппа студента: " + paramtr[i + 2] + "\nДата рождения студента: " + paramtr[i + 3] + "\n");
                    break;
                }
            }
        }
        public static void Years(int index)
        {
            string date = "";
            string DATE = "";
            for (int i = 0; i < paramtr.Count - 2; i++)
            {
                if (paramtr[i].ToString().Equals(index.ToString()))
                {
                    date += paramtr[i + 3].ToString();
                    for (int j = 6; j < date.Length; j++)
                    {
                        DATE += date[j];
                    }
                    Convert.ToInt32(DATE);
                    Console.WriteLine(2021 - Convert.ToInt32(DATE));
                    break;
                }
            }
        }
    }
}
