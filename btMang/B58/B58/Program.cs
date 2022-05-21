using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_171 = 1000;
            bool[] check_171 = new bool[n_171 + 1];
            do
            {
                Console.Write("nhap n > 0: ");
                n_171 = int.Parse(Console.ReadLine());
            } while (n_171 <= 0);
            for (int i = 2; i <= n_171; i++)
            {
                check_171[i] = true;
            }
            for (int i = 2; i <= n_171; i++)
            {
                if (check_171[i] == true)
                {
                    for (int j = 2 * i; j <= n_171; j += i)
                    {
                        check_171[j] = false;
                    }
                }
            }
            // In ra các số là số nguyên tố
            Console.Write("Cac so nguyen to nho hon {0} la: ", n_171);
            for (int i = 2; i <= n_171; i++)
            {
                if (check_171[i] == true)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
