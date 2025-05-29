class Program
{
    public static void BubbleSort(int[] array, out int comparisons, out int swaps)
    {
        int n = array.Length;
        comparisons = 0;
        swaps = 0;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                comparisons++;
                if (array[j] > array[j + 1])
                {
                    // обмен
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swaps++;
                }
            }
        }
    }

    public static void ShakerSort(int[] array, out int comparisons, out int swaps)
    {
        int left = 0;
        int right = array.Length - 1;
        comparisons = 0;
        swaps = 0;

        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                comparisons++;
                if (array[i] > array[i + 1])
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    swaps++;
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                comparisons++;
                if (array[i - 1] > array[i])
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    swaps++;
                }
            }
            left++;
        }
    }

    static void Main()
    {
        int[] arr1 = { 5, 3, 4, 1, 2 };
        int[] arr2 = (int[])arr1.Clone();

        BubbleSort(arr1, out int bComp, out int bSwap);
        ShakerSort(arr2, out int sComp, out int sSwap);

        Console.WriteLine("Пузырьковая сортировка: " + string.Join(", ", arr1));
        Console.WriteLine($"Сравнений: {bComp}, обменов: {bSwap}");

        Console.WriteLine("Шейкерная сортировка: " + string.Join(", ", arr2));
        Console.WriteLine($"Сравнений: {sComp}, обменов: {sSwap}");
    }

}
/*
 Сортировка — это упорядочивание данных (например, по возрастанию или убыванию). Она используется:

для удобного поиска (например, бинарный поиск работает только на отсортированных массивах);

для сравнения, группировки, фильтрации;

в алгоритмах: обработки текстов, чисел, таблиц, баз данных.
 
 
 */