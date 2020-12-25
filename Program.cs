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
namespace _2дан_1массив_поменять_местами
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int temp;
            PrintArray(array);
            for (int i = 0; i < array.Length - 1; i++)
            {
                temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                i++;
            }
            PrintArray(array);
            Console.ReadLine();
        }
        private static void PrintArray(int[] array)
        {
            foreach (int element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }
    }
}
namespace _3Данмас_10_3чисел.мин_маусзхамена
{
    class Program
    {
        static void Main(string[] args)
        {
            int b,c,d,p,p1;
            p = 0;
            //a = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[10];
            int[] myArray = new int[10];
            Random rand = new Random();
            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(100, 999);
                Console.WriteLine(myArray[x]);
                d = myArray[x] / 100;
                c = myArray[x] / 10 % 10;
                b = myArray[x]% 10;
                if (d > b && d > c)
                    p = d;
                else if (b > c)
                    p=d;
                else
                    p=c;
                if (d < b && d < c)
                    p1 = d;
                else if (b < c)
                    p1 = d;
                else
                    p1 = c;
                nums[x] = p - p1;
                p = 0;
                p1 = 0;
            };
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
                Console.WriteLine();
            Console.ReadKey();
        }

    }
}
namespace _5_Дан_2мерный_массив_найти_отр_в_кажд_стр
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Random r = new Random();
            int sum_str = 0;
            Console.WriteLine("Существующая матрица");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = r.Next(-100, 100);
                    if(matrix[i, j]<0)
                        sum_str += matrix[i, j]; 
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("Сумма отрицательных элементов  " + sum_str);
                sum_str = 0;
            }
            Console.ReadLine();
        }
    }
}
namespace _6_2мас_мин_номер_ст_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            Random r = new Random();
            int p = 0;
            Console.WriteLine("Существующая матрица");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = r.Next(-100, 100);
                    Console.WriteLine(matrix[i, j] + ' ');
                    if (matrix[i, j] > 10)
                    {
                        p++;
                        if (p == 3)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
namespace _7изв_1мас_равн5_индекс
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 5, 3, 4, 5, 6, 7, 8, 5, 8 };
            int index = 0;
            a.First(n => { index++; return n == 5; });
            Console.WriteLine("Номер первого элемента:" + index);
            Console.ReadKey();
        }
    }
}
namespace _8Дан_массив_поменят_посл_с_первым
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            int maxVal = a.Max();
            int indexMax = Array.IndexOf(a, maxVal);
            int h = 0;
            h = a[0];
            a[0] = a[maxVal]+1;
            a[maxVal] = h;
            for (int x = 0; x < a.Length; x++)
            {
                Console.WriteLine(a[x]);
            }
                Console.WriteLine();
            Console.ReadKey();
        }
    }
}
namespace _13_дано_нат_число_найти_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите цифру");
            char ch = Convert.ToChar(Console.ReadLine());
            int indexOfChar = s1.IndexOf(ch);
            if (indexOfChar == -1)
                Console.WriteLine("Такой цифры нет");
            else
                Console.WriteLine("Цифра есть");
            Console.ReadKey();
        }
    }
}
