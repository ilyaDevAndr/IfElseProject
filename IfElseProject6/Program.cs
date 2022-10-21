using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProject6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f, x, y; // обьявление переменных вещественного типа
            Console.Write("Введите x="); // вывод на экран
            x = Convert.ToDouble(Console.ReadLine()); // присваивание значения
            Console.Write("Введите y="); // вывод на экран
            y = Convert.ToDouble(Console.ReadLine()); // присваивание значения
            // проверка условия
            if (x > y + 1)
            {
                f = Math.Pow(x, -4); // возводим x в -4 степень и присваиваем переменной f
            }
            else
            {
                f = (y - x + 1) / (Math.Pow(x, 2) + 1);
            }
            // округление результата
            f = Math.Round(f, 6);
            // вывод на экран
            Console.WriteLine($" f= " + f);
            Console.WriteLine("Козырский Илья 24ИС");
            Console.ReadKey(); // закрытие программы по нажатию на любую клавишу клавиатуры

        }
    }
}
