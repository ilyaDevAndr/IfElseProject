using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, f; // обьявляем переменные
            Console.Write("Введите x="); // вывод на экран
            // присваиваем переменные
            x = Convert.ToDouble(Console.ReadLine()); // присвоение значения x
            Console.Write("Введите y="); // вывод на экран 
            y = Convert.ToDouble(Console.ReadLine()); // присвоение значения y
            // проверка условия
            if (x > y)
            {
                f = Math.Sin(x) - y; // вычисление результата
                Console.WriteLine(" f=" + f); // вывод на экран
            }
            else
            {
                f = Math.Cos(y - x) + 1; // вычисление результата
                f = Math.Round(f, 2);
                Console.WriteLine(" f=" + f); // вывод на экран
            }
            Console.WriteLine("Козырский Илья 24ИС"); Console.ReadKey(); // закрытие программы по нажатию на любую клавишу клавиатуры

        }
    }
}
