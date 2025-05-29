using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class Linear : IEquation
    {
        double a, b;

        public Linear(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public string Name => "Линейное уравнение";
        public string Parameters => $"a = {a}, b = {b}";

        public void Roots()
        {
            if (a == 0)
            {
                Console.WriteLine(b == 0 ? "Бесконечно много решений." : "Решений нет.");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"x = {x}");
            }
        }
    }

}
