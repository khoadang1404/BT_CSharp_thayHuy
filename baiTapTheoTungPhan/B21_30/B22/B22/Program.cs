using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhaplai:
            Console.Write("Nhập số: ");
            string x = Console.ReadLine();
            int a_171 = int.Parse(x);
            if(a_171 < 0)
            {
                Console.Write("Nhập sai\n");
                goto nhaplai;
            }
            else
            {
                int dem_171 = 0, tong_171 = 0;
                Console.WriteLine("các ước số là: ");
                for (int i = 1; i <= a_171; i++)
                {
                    if (a_171 % i == 0)
                    {
                        dem_171 += 1;
                        Console.Write(i + " ");
                        tong_171 += i;
                    }
                }
                Console.Write("\nCó {1} ước, tổng các ước số là: {0}", tong_171, dem_171);
            }
            Console.ReadKey();
        }
    }
}
