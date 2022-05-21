using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B61
{
    internal class Program
    {
        static void deletePoint(int[] a, int n, int p)
        {
            for (int i = p; i < n - 1; i++)
            {
                a[i] = a[i + 1]; // 1 2 3 4 
            }
        }
        static void Main(string[] args)
        {
            int n_171, sum_171;
            sum_171 = 0;
            int[] a = new int[100];
            do
            {
                Console.Write("Nhap vao n [1-99] : ");
                n_171 = Convert.ToInt32(Console.ReadLine());
            } while (0 > n_171 || n_171 > 99);
            Random ran = new Random();
            for (int i = 0; i < n_171; i++)
            {
                a[i] = ran.Next(-100, 100);
                if (a[i] > 0)
                {
                    sum_171 += a[i];
                }
                Console.Write(a[i] + " ");
            }
            Console.Write("\n Tong Cac So Nguyen Duong: " + sum_171);
            int p;
            do
            {
                Console.Write("\nNhap vao p [0,9] : ");
                p = Convert.ToInt32(Console.ReadLine());
            } while (0 > n_171 || n_171 > 9);
            Console.Write("Danh sach sau khi xoa vi tri {0} :", p);
            deletePoint(a, n_171, p);
            n_171--;
            for (int i = 0; i < n_171; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
