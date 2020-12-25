using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_матрица_и_3_массива
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] massive1;
            //int[,] matrix = new int[3, 3];
            //Random r = new Random();
            //int sum_str = 0;
            //Console.WriteLine("Существующая матрица");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        matrix[i, j] = r.Next(-100, 100);
            //        if (matrix[i, j] < 0)
            //        {

            //        }


            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine("Сумма отрицательных элементов  " + sum_str);
            //    sum_str = 0;
            //}
            //Console.ReadLine();
            int x = 5, y = 5;
            Random rand = new Random();
            int[,] Matrix = new int[x, y];
            int[] Even;
            int[] UnEven;
            int[] minus;
            int EV = 0, UN = 0, min=0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Matrix[i, j] = rand.Next(-10,10);
                    Console.Write(" " + Matrix[i, j]);
                    if (Matrix[i, j] % 2 == 0)
                        EV++;
                    else
                        UN++;
                    if (Matrix[i, j] < 0)
                        min++;

                }
                Console.WriteLine();
            }
            Even = new int[EV];
            UnEven = new int[UN];
            minus = new int[min];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (Matrix[i, j] % 2 == 0)
                        Even[--EV] = Matrix[i, j];
                    else
                        UnEven[--UN] = Matrix[i, j];
                    if (Matrix[i, j] < 0)
                        minus[--min] = Matrix[i, j];
                }
            }
            Console.WriteLine();
            for (int i = 0; i < Even.Length; i++)
                Console.Write(" " + Even[i]);
            Console.WriteLine();
            for (int i = 0; i < minus.Length; i++)
                Console.Write(" " + minus[i]);
            Console.WriteLine();
            for (int i = 0; i < UnEven.Length; i++)
                Console.Write(" " + UnEven[i]);
            Console.ReadLine();
        }
    }
}