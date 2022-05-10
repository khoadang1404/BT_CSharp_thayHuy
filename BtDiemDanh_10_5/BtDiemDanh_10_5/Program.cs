using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtDiemDanh_10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr_171 = new int[100];
            int i, n_max_171, n_min_171;
            Console.Write("Bai tap diem danh 10/5/2022\nNhap 10 phan tu bat ki:\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                arr_171[i] = Convert.ToInt32(Console.ReadLine());
            }
            n_max_171 = arr_171[0];
            n_min_171 = arr_171[0];

            for (i = 1; i <= 10; i++)
            {
                if (arr_171[i] > n_max_171)
                {
                    n_max_171 = arr_171[i];
                }

                if (arr_171[i] < n_min_171)
                {
                    n_min_171 = arr_171[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", n_max_171);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n", n_min_171);
            Console.Write("Sap xep mang tang dan:\n");
            for (i = 1; i <= 10; i++)
            {
                for (int j = i + 1; j <= 10; j++)
                {
                    if (arr_171[i] > arr_171[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = arr_171[i];
                        arr_171[i] = arr_171[j];
                        arr_171[j] = temp;
                    }
                }
            }

            for (i = 1; i <= 10; i++)
            {
                Console.Write(arr_171[i] + " ");
            }
            Console.Write("\nSap xep mang giam dan:\n");
            for (i = 1; i <= 10; i++)
            {
                for (int k = i + 1; k <= 10; k++)
                {
                    if (arr_171[i] < arr_171[k])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp = arr_171[i];
                        arr_171[i] = arr_171[k];
                        arr_171[k] = temp;
                    }
                }
            }

            for (i = 1; i <= 10; i++)
            {
                Console.Write(arr_171[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
