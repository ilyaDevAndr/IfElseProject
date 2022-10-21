using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProject8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, f;
            Console.Write("Введите x=");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y=");
            y = Convert.ToDouble(Console.ReadLine());
            if (x > 2 * y)
            {
                f = Math.Abs(x + y);
            }
            else
            {
                f = 2 * x + 3 * y;
            }
            Console.WriteLine(" f=" + f);
            Console.WriteLine("Козырский Илья 24ИС");
            Console.ReadKey();

        }
    }
}
