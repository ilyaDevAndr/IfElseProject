using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, f; // обьявялем переменные
            Console.Write(" Введите x"); // вывод на экран
            x = Convert.ToDouble(Console.ReadLine()); // присваиваиваем значение 
            if ((x >= -2) && (x <= 2)) // проверка условия
                f = Math.Pow(x, 2);
            else
                f = 4;
            // вывод на экран
            Console.WriteLine(" f=" + f);
            Console.WriteLine("Козырский Илья 24ИС");
            Console.ReadKey(); // закрытие программы по нажатию на клавишу клавиатуры
        }
    }
}
