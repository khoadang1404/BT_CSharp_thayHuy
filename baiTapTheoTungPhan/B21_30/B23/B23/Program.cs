using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhap:
            Console.Write("Nhập số: ");
            string so = Console.ReadLine();
            int so_171 = int.Parse(so);
            if(so_171 <= 0)
            {
                Console.Write("nhập sai\n");
                goto nhap;
            }
            else
            {
                Console.Write("các số hoàn hảo: ");
                for(int i = 1; i <= so_171; i++)
                {
                    int sum = 0;
                    for(int j = 1; j < i; j++)
                    {
                        if(i % j == 0)
                        {
                            sum += j;
                        }
                    }
                    if(sum == i)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
