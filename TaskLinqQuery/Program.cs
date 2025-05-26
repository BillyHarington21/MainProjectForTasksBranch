class Program
{
    static void Main()
    {
        try
        {
            // Вводим параметры
            Console.Write("Введите количество элементов n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите нижнюю границу диапазона a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите верхнюю границу диапазона b: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Ошибка: a должно быть меньше или равно b.");
                return;
            }

            // Генерация случайных чисел
            Random rnd = new Random();
            List<int> numbers = Enumerable.Range(0, n).Select(_ => rnd.Next(a, b + 1)).ToList();

            Console.WriteLine("\nСгенерированный список:");
            Console.WriteLine(string.Join(", ", numbers));

            // 1) Положительные элементы, сортировка
            var positiveSorted = numbers.Where(x => x > 0).OrderBy(x => x).ToList();
            Console.WriteLine("\n1) Положительные числа (сортировка):");
            Console.WriteLine(string.Join(", ", positiveSorted));

            // 2) Сумма положительных двухзначных
            var sumTwoDigitPositive = numbers.Where(x => x > 0 && x >= 10 && x <= 99).Sum();
            Console.WriteLine($"\n2) Сумма положительных двухзначных чисел: {sumTwoDigitPositive}");

            // 3) Кол-во элементов, значение по модулю > 10 и кратны 5
            var countModMore10AndDiv5 = numbers.Where(x => Math.Abs(x) > 10 && x % 5 == 0).Count();
            Console.WriteLine($"\n3) Кол-во элементов |x| > 10 и x % 5 == 0: {countModMore10AndDiv5}");

            // 4) Максимальный нечетный элемент
            var maxOdd = numbers.Where(x => x % 2 != 0).DefaultIfEmpty(int.MinValue).Max();
            if (maxOdd == int.MinValue)
                Console.WriteLine("\n4) Нечетных элементов нет.");
            else
                Console.WriteLine($"\n4) Максимальный нечетный элемент: {maxOdd}");

            // 5) Есть ли отрицательные, кратные 3
            bool hasNegativeDiv3 = numbers.Any(x => x < 0 && x % 3 == 0);
            Console.WriteLine($"\n5) Есть ли отрицательные, кратные 3: {(hasNegativeDiv3 ? "Да" : "Нет")}");

            // 6) Первый отрицательный нечетный элемент
            var firstNegOdd = numbers.FirstOrDefault(x => x < 0 && x % 2 != 0);
            if (numbers.Any(x => x < 0 && x % 2 != 0))
                Console.WriteLine($"\n6) Первый отрицательный нечетный элемент: {firstNegOdd}");
            else
                Console.WriteLine("\n6) Отрицательных нечетных элементов нет.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}