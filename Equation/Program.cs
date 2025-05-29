using Equation;

class Program
{
    static void Main()
    {
        List<double> coeffs = InputParametrs();

        if (coeffs.Count == 2)
        {
            IEquation eq = new Linear(coeffs[0], coeffs[1]);
            PrintInfo(eq);
        }
        else if (coeffs.Count == 3)
        {
            IEquation eq = new Quadratic(coeffs[0], coeffs[1], coeffs[2]);
            PrintInfo(eq);
        }
        else
        {
            Console.WriteLine("Неверное количество параметров. Уравнение не создано.");
        }
    }

    public static List<double> InputParametrs()
    {
        Console.WriteLine("Введите коэффициенты уравнения через пробел (2 — линейное, 3 — квадратное):");

        string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<double> coefficients = new List<double>();

        foreach (var part in parts)
        {
            if (double.TryParse(part, out double value))
            {
                coefficients.Add(value);
            }
            else
            {
                Console.WriteLine($"Ошибка: '{part}' не является числом.");
                return new List<double>(); // Возврат пустого списка — сигнал об ошибке
            }
        }

        if (coefficients.Count != 2 && coefficients.Count != 3)
        {
            Console.WriteLine("Ошибка: введите либо 2, либо 3 коэффициента.");
            return new List<double>();
        }

        return coefficients;
    }


    public static void PrintInfo(IEquation eq)
    {
        Console.WriteLine($"Тип уравнения: {eq.Name}");
        Console.WriteLine($"Параметры: {eq.Parameters}");
        Console.Write("Корни: ");
        eq.Roots();
        Console.WriteLine();
    }
}