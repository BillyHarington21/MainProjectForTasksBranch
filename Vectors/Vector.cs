using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Vector
    {
        // Поля
        public double x;
        public double y;

        // Конструктор, принимающий координаты вектора
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Метод, возвращающий длину вектора
        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // Операция сложения двух векторов
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }

        // Операция вычитания двух векторов
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y);
        }

        // Операция скалярного умножения вектора на вектор
        public static double operator *(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }

        // Операция умножения на число
        public static Vector operator *(Vector v1, double a)
        {
            return new Vector(v1.x * a, v1.y * a);
        }

        // Операция деления на число
        public static Vector operator /(Vector v1, double a)
        {
            return new Vector(v1.x / a, v1.y / a);
        }

        // Метод для строкового представления вектора
        public override string ToString()
        {
            return $"({x}; {y})";
        }
    }
}

