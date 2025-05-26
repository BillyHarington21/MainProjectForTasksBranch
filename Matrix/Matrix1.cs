using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix1
    {
        private double a11, a12, a21, a22;

        // Конструктор
        public Matrix1(double a11, double a12, double a21, double a22)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a21 = a21;
            this.a22 = a22;
        }



        // Метод определителя
        public double Det()
        {
            return a11 * a22 - a12 * a21;
        }

        // Метод транспонирования
        public Matrix1 Transpose()
        {
            return new Matrix1(a11, a21, a12, a22);
        }

        // Операция сложения матриц
        public static Matrix1 operator +(Matrix1 m1, Matrix1 m2)
        {
            return new Matrix1(
                m1.a11 + m2.a11,
                m1.a12 + m2.a12,
                m1.a21 + m2.a21,
                m1.a22 + m2.a22
            );
        }

        // Операция вычитания матриц
        public static Matrix1 operator -(Matrix1   m1, Matrix1 m2)
        {
            return new Matrix1(
                m1.a11 - m2.a11,
                m1.a12 - m2.a12,
                m1.a21 - m2.a21,
                m1.a22 - m2.a22
            );
        }

        // Операция умножения: матрица * матрица
        public static Matrix1 operator *(Matrix1 m1, Matrix1 m2)
        {
            return new Matrix1(
                m1.a11 * m2.a11 + m1.a12 * m2.a21,
                m1.a11 * m2.a12 + m1.a12 * m2.a22,
                m1.a21 * m2.a11 + m1.a22 * m2.a21,
                m1.a21 * m2.a12 + m1.a22 * m2.a22
            );
        }

        // Операция умножения: матрица * число
        public static Matrix1 operator *(Matrix1 m, double scalar)
        {
            return new Matrix1(
                m.a11 * scalar, m.a12 * scalar,
                m.a21 * scalar, m.a22 * scalar
            );
        }

        // Метод для вывода матрицы
        public void Print()
        {
            Console.WriteLine($"[{a11,6:0.##} {a12,6:0.##}]");
            Console.WriteLine($"[{a21,6:0.##} {a22,6:0.##}]");
        }
    }
}
