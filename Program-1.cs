using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторна_робота_2_пункт_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // змінні 1
            Console.WriteLine("Змінні 1: a - тип 'long', b - тип 'long', с - тип 'byte'");
            Console.WriteLine("Примітка:");
            Console.WriteLine("тип 'long' - число від -9223372036854775808 до 9223372036854775807");
            Console.WriteLine("тип 'byte' - число від 0 до 255");
            Console.WriteLine();

            // частина для введення змінної a1
            Console.Write("Введіть змінну a 'long': ");
            long a1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Ви ввели значення змінної а = " + a1);
            Console.WriteLine();

            // частина для введення змінної b1
            Console.Write("Введіть змінну b 'long': ");
            long b1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Ви ввели значення змінної b = " + b1);
            Console.WriteLine();

            // частина для введення змінної c1
            Console.Write("Введіть змінну c 'byte': ");
            byte c1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ви ввели значення змінної c = " + c1);
            Console.WriteLine();

            // частина розрахунків змінних 1
            long result1 = a1 - b1 - c1;
            long result2 = a1 + b1 + c1;
            byte result3 = (byte)(a1 - (b1 - c1));

            // виведення результату змінних 1
            Console.WriteLine("Результати розрахунків: ");
            Console.WriteLine("a - b - c = " + result1);
            Console.WriteLine("a + b + c = " + result2);
            Console.WriteLine("a - (b - c) = " + result3);
            Console.WriteLine();
            Console.WriteLine("-----------------  кінець розрахунку -----------------");

        }
    }
}
