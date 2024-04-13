using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perevantaz
{
    internal class Task2
    {
        public class Matrix
        {
            private int[,] data;

            public int Rows { get; private set; }
            public int Columns { get; private set; }

            public Matrix(int rows, int columns)
            {
                Rows = rows;
                Columns = columns;
                data = new int[rows, columns];
            }

            public int this[int i, int j]
            {
                get { return data[i, j]; }
                set { data[i, j] = value; }
            }

            // Перевантаження оператора додавання
            public static Matrix operator +(Matrix a, Matrix b)
            {
                if (a.Rows != b.Rows || a.Columns != b.Columns)
                    throw new ArgumentException("Matrices must have the same dimensions for addition.");

                Matrix result = new Matrix(a.Rows, a.Columns);

                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Columns; j++)
                    {
                        result[i, j] = a[i, j] + b[i, j];
                    }
                }

                return result;
            }

            // Перевантаження оператора віднімання
            public static Matrix operator -(Matrix a, Matrix b)
            {
                if (a.Rows != b.Rows || a.Columns != b.Columns)
                    throw new ArgumentException("Matrices must have the same dimensions for subtraction.");

                Matrix result = new Matrix(a.Rows, a.Columns);

                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Columns; j++)
                    {
                        result[i, j] = a[i, j] - b[i, j];
                    }
                }

                return result;
            }

            // Перевантаження оператора множення на число
            public static Matrix operator *(Matrix a, int scalar)
            {
                Matrix result = new Matrix(a.Rows, a.Columns);

                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Columns; j++)
                    {
                        result[i, j] = a[i, j] * scalar;
                    }
                }

                return result;
            }

            // Перевантаження оператора множення матриць
            public static Matrix operator *(Matrix a, Matrix b)
            {
                if (a.Columns != b.Rows)
                    throw new ArgumentException("Number of columns of first matrix must be equal to number of rows of second matrix for multiplication.");

                Matrix result = new Matrix(a.Rows, b.Columns);

                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < b.Columns; j++)
                    {
                        for (int k = 0; k < a.Columns; k++)
                        {
                            result[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                return result;
            }

            // Перевантаження оператора порівняння для перевірки рівності матриць
            public static bool operator ==(Matrix a, Matrix b)
            {
                if (a.Rows != b.Rows || a.Columns != b.Columns)
                    return false;

                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Columns; j++)
                    {
                        if (a[i, j] != b[i, j])
                            return false;
                    }
                }

                return true;
            }

            // Перевантаження оператора порівняння для перевірки нерівності матриць
            public static bool operator !=(Matrix a, Matrix b)
            {
                return !(a == b);
            }

            // Перевизначення методу Equals для порівняння матриць
            public override bool Equals(object obj)
            {
                if (!(obj is Matrix))
                    return false;

                Matrix other = (Matrix)obj;

                if (this.Rows != other.Rows || this.Columns != other.Columns)
                    return false;

                for (int i = 0; i < this.Rows; i++)
                {
                    for (int j = 0; j < this.Columns; j++)
                    {
                        if (this[i, j] != other[i, j])
                            return false;
                    }
                }

                return true;
            }
        }

 
    }
}
