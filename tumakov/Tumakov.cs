using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2.1");

            Console.WriteLine("Какое у тебя имя?");
            string imya = Console.ReadLine(0);
            Console.Write("Привет! ");
            Console.WriteLine(imya);

            Console.WriteLine("Задание 2.2");
            
            Console.WriteLine("Введите 2 целых числа");  
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ( b == 0)
            {
                Console.WriteLine("ВЫ ВВЕЛИ НОЛЬ ТАКОГО НЕ МОЖЕТ БЫТЬ, МЫ НЕ МОЖЕМ ДЕЛИТЬ НА НОЛЬ");
            }
            else
            {
                Console.WriteLine(a / b);
            }

            Console.WriteLine("Задание дз 2.1");

            char[] alfaBET = "абвгдеёжзиклмнопрстуфхцчщьъэюя".ToCharArray();
            int index = Array.IndexOf(alphabet, inputChar);
            Console.WriteLine($"Следующая буква: {nextChar}");

            Console.WriteLine("Задание дз 2.2");
            Console.WriteLine("Введите 3 коэфицента квдратного уравнения");
            int we = int.Parse(Console.ReadLine());
            int er = int.Parse(Console.ReadLine());
            int rt = int.Parse(Console.ReadLine());
            double discr = Math.Sqrt(er * er - 4 * er * rt);
            Console.WriteLine((-er + discr) / 2 * we);
            Console.WriteLine((-er - discr) / 2 * we);

        }
    }
}
