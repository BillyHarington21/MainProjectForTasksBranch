using Matrix;

class Program
{
    static void Main()
    {
        var a = InputMatrix();
        var b = InputMatrix();

        var m1 = new Matrix1(a[0], a[1], a[2], a[3]);
        var m2 = new Matrix1(b[0], b[1], b[2], b[3]);

        Console.WriteLine("Матрица m1:");
        m1.Print();

        Console.WriteLine("\nМатрица m2:");
        m2.Print();

        Console.WriteLine("\nСумма m1 + m2:");
        (m1 + m2).Print();

        Console.WriteLine("\nРазность m1 - m2:");
        (m1 - m2).Print();

        Console.WriteLine("\nПроизведение m1 * m2:");
        (m1 * m2).Print();

        Console.WriteLine("\nУмножение m1 на число 2:");
        (m1 * 2).Print();

        Console.WriteLine($"\nОпределитель m1: {m1.Det()}");

        Console.WriteLine("\nТранспонированная m1:");
        m1.Transpose().Print();
    }

    static double[] InputMatrix()
    {
        double[] a = new double[4];
        while (true)
        {
            Console.WriteLine("Введите 4 элемента матрицы через пробел:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 4 && parts.All(p => double.TryParse(p, out _)))
            {
                for (int i = 0; i < 4; i++)
                    a[i] = double.Parse(parts[i]);
                break;
            }

            Console.WriteLine("Ошибка! Введите ровно 4 числа.");
        }
        return a;
    }
}