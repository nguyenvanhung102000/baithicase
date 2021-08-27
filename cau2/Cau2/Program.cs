using System;

namespace Cau2
{
    class Program
    {
        static int Menu()
        {
            int choose;
            Console.WriteLine("MENU");
            Console.WriteLine("1. Tạo mảng");
            Console.WriteLine("2. Kiểm tra mang đối xứng");
            Console.WriteLine("3. Sắp xếp mảng");
            Console.WriteLine("4. Tìm kiếm mảng");
            Console.WriteLine("5. Thoát");
            Console.Write("Choose a function: ");
            choose = int.Parse(Console.ReadLine());
            return choose;
        }
        static int[] CreateArray()
        {
            int n;
            Console.Write("So phan tu : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Nhap phan tu " + (i + 1).ToString() + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static bool IsSymmetryArray(int[] arr, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsArray(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void BubbleSort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int tmp = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[tmp])
                        tmp = j;
                int temp = arr[tmp];
                arr[tmp] = arr[i];
                arr[i] = temp;
            }
        }
        static int Find(int[] arr, int l, int r, int x)
        {
            if (IsArray(arr, arr.Length))
            {
                return -2;
            }
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return Find(arr, l, mid - 1, x);
                return Find(arr, mid + 1, r, x);
            }
            return -1;
        }
        static void Display(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\n{arr[i]} ");
            }
        }
        private static int[] arr;
        private static int n;
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choose;
            do
            {
                choose = Menu();
                switch (choose)
                {
                    case 1:
                        arr = CreateArray();
                        n = arr.Length;
                        break;
                    case 2:
                        bool check = IsSymmetryArray(arr, n);
                        if (check)
                        {
                            Console.WriteLine("mảng đối xứng");
                        }
                        else
                        {
                            Console.WriteLine("mảng không đối xứng");
                        }
                        break;
                    case 3:
                        BubbleSort(arr, n);
                        Console.WriteLine();
                        Display(arr, n);
                        break;
                    case 4:
                        Console.Write("Nhập số cần tìm: ");
                        int x = int.Parse(Console.ReadLine());
                        int index = Find(arr, 0, n - 1, x);
                        if (index == -2)
                        {
                            Console.WriteLine("Mảng không tăng");
                        }
                        else if (index == -1)
                        {
                            Console.WriteLine("Không tìm thấy");
                        }
                        else
                        {
                            Console.WriteLine("Vị trí: " + index);
                        }
                        break;
                    case 5:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Choose again");
                        break;
                }
            } while (choose != 5);
            Console.ReadLine();
        }
    }
}
