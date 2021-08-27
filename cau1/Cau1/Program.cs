using System;

namespace Cau1
{
    class Program
    {
        public static int[,] matrix;
        public static int m;
        public static int n;
        static void Main(string[] args)
        {
            Console.Write(" Nhap so dong: ");
            m = int.Parse(Console.ReadLine());
            Console.Write(" Nhap so cot: ");
            n = int.Parse(Console.ReadLine());
            matrix = initMatrix(m, n);
            Display(matrix, m, n);
            Sum(matrix, m, n);
            Console.WriteLine(FindMaxRow(matrix, m, n));
        }
        static int[,] initMatrix(int m, int n)
        {
            int[,] matrix = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" Nhap phan tu : " + i + "    " + j + " : ");
                    int num = int.Parse(Console.ReadLine());
                    matrix[i, j] = num;
                }
            }
            return matrix;
        }
        static void Sum(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine($"Tong gia tri dong {i + 1} : {sum}");
            }
        }
        static int FindMaxRow(int[,] arr, int m, int n)
        {
            int max = 0;
            int maxtmp = 0;
            for (int i = 0; i < m; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += arr[i, j];
                }
                if (sum > maxtmp)
                {
                    maxtmp = sum;
                    max = i;
                }
            }
            return max;
        }
        static void Display(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
       

