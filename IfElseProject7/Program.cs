using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, f; // обьявляем переменные
            Console.Write("Введите x="); // вывод на экран
            x = Convert.ToDouble(Console.ReadLine()); // присваивание значения переменной
            Console.Write("Введите y="); // вывод на экран
            y = Convert.ToDouble(Console.ReadLine()); // присваивание значение переменной
            // проверка условия
            if (x > y)
            {
                f = Math.Log(x - y); // математический натуральный логарифм
            }
            else
            {
                f = y - x + 1;
            }
            // вывод на экран
            Console.WriteLine(" f=" + f);
            Console.WriteLine("Козырский Илья 24ИС");
            Console.ReadKey(); // закрытие программы по нажатию клавиши

        }
    }
}
