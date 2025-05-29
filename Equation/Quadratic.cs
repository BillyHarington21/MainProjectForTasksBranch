using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    public class Quadratic : IEquation
    {
        double a, b, c;

        public Quadratic(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Name => "Квадратное уравнение";
        public string Parameters => $"a = {a}, b = {b}, c = {c}";

        public void Roots()
        {
            if (a == 0)
            {
                Console.WriteLine("Это не квадратное уравнение. Передаём обработку как линейное.");
                new Linear(b, c).Roots();
                return;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет.");
            }
        }
    }
}
