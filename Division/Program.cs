
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static List<string> InputEmploers()
    {
        List<string> table = new List<string> { };
        Console.WriteLine(" Введите данные");
        string data;
        do
        {
            data = Console.ReadLine();
            string[] parts = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if ((parts[0].Length > 20) && (parts[1].Length > 4) && ((parts[3].Length > 8) && ((parts[3][4] != '-') && (parts[3][6] != '-'))))
            {
                Console.WriteLine("ошибка, вы ввели неверно данные, повторите ввод");
            }
            else
            {
                table.Add(data);
            }                       

        } while (!data.EndsWith("."));     

        return table;        
    }

    static void CountDepartments(List<string> table)
    {
        // Словарь для подсчёта сотрудников по номеру телефона
        Dictionary<string, int> departmentCounts = new Dictionary<string, int>();

        foreach (var line in table)
        {
            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length < 3)
            {
                Console.WriteLine("Ошибка: строка не содержит всех частей.");
                continue;
            }

            string phone = parts[2]; // третий элемент — это телефон

            if (departmentCounts.ContainsKey(phone))
                departmentCounts[phone]++;
            else
                departmentCounts[phone] = 1;
        }

        // Вывод результата
        Console.WriteLine("\nКоличество сотрудников по подразделениям:");
        foreach (var kvp in departmentCounts)
        {
            Console.WriteLine($"Телефон {kvp.Key}: {kvp.Value} сотрудник(ов)");
        }
    }


    static void Main()
    {         
       List<string> table = InputEmploers();
       CountDepartments(table);
    }
}
