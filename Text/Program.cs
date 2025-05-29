using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        // Находим максимальную частотуарбуз арбуз
        int maxCount = wordCount.Values.Max();

        // Отбираем все слова с этой частотой
        var needWords = wordCount
            .Where(pair => pair.Value == maxCount)
            .Select(pair => pair.Key)
            .ToList();

        // Выбираем минимальное по алфавиту
        string result = needWords.Min();

        if (needWords.Count > 1)
        {            
            Console.WriteLine(" Выбрано минимальное в лексикографическом порядке.");
        }
        else
        {
            Console.WriteLine(" Это единственное слово с наибольшей частотой.");
        }
        Console.WriteLine(result);
    }
}
