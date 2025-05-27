using System.Numerics;
using Vectors;

namespace Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров класса Vector2
            Vector vector1 = new Vector(2, 2);
            Vector vector2 = new Vector(4, 6);
                      
            Console.WriteLine($"vector1: {vector1}");
            Console.WriteLine($"vector2: {vector2}");

            // Длины 
            Console.WriteLine($"Длина vector1: {vector1.Length():F3}");
            Console.WriteLine($"Длина vector2: {vector2.Length():0.000}");

            // Сложение
            Console.WriteLine($"vector1 + vector2 = {vector1 + vector2}");

            // Вычитание
            Console.WriteLine($"vector1 - vector2 = {vector1 - vector2}");

            // Скалярное
            Console.WriteLine($"vector1 * vector2 = {vector1 * vector2}");

            // Умножение на число
            Console.WriteLine($"vector1 * 5 = {vector1 * 5}");

            // Деление на число
            Console.WriteLine($"vector2 / 2 = {vector2 / 2}");

            Console.ReadLine();
        }
    }

}
