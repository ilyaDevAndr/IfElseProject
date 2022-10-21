using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // обьявление переменных вещественного типа
            double x, y, f;
            // вывод на экран
            Console.Write("Введите x=");
            // присваивание значения
            x = Convert.ToDouble(Console.ReadLine());
            // вывод на экран
            Console.Write("Введите y=");
            // присваивания значения y
            y = Convert.ToDouble(Console.ReadLine());
            // проверка условия
            if (x > 0)
                f = Math.Exp(x - y);

            else
                f = y - x + 1;
            // вывод на экран
            f = Math.Round(f, 2);
            Console.WriteLine($"f = " + f);
            Console.WriteLine("Козырский Илья 24ИС");
            // закрытие программы по нажатию клавиши клавиатуры
            Console.ReadKey();

        }
    }
}
