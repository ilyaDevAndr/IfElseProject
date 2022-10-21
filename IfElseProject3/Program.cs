using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, f; // обьявление переменных
            Console.Write("Введите x="); // вывод на экран
            x = Convert.ToDouble(Console.ReadLine()); // присваивание значения
            Console.Write("Введите y="); // вывод на экран
            y = Convert.ToDouble(Console.ReadLine()); // присваивание значения
            // проверка условия
            if (x < y + 2)
                f = x - y;
            else
                f = y;
            // вывод на экран
            Console.WriteLine("f=" + f);
            Console.WriteLine("Козырский Илья 24ИС"); Console.ReadKey(); // закрытие программы по нажатию клавиши

        }
    }
}
