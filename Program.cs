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

            // змінні 2
            Console.WriteLine("Змінні 2: a - тип 'double', b - тип 'double'");
            Console.WriteLine("Примітка:");
            Console.WriteLine("тип 'double' - від ± 5.0 * 10^-324 до ± 1.7х10^308");
            Console.WriteLine();

            // частина для введення змінної a2
            Console.Write("Введіть змінну a 'double': ");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ви ввели значення змінної а = " + a2);
            Console.WriteLine();

            // частина для введення змінної b2
            Console.Write("Введіть змінну b 'double': ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ви ввели значення змінної b = " + b2);
            Console.WriteLine();

            // частина розрахунків змінних 2
            double result4 = a2 * b2 * b2;
            double result5 = a2 / (b2 - a2);

            // виведення результату змінних 2
            Console.WriteLine("Результати розрахунків: ");
            Console.WriteLine("a * b * b = " + result4);
            Console.WriteLine("a / (b - a) = " + Math.Round(result5, 4)); // 4 знаки після коми
            Console.WriteLine();
            Console.WriteLine("-----------------  кінець розрахунку -----------------");

        }
    }
}
