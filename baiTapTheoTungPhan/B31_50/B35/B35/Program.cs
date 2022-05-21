using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhap:
            Console.Write("Nhập số: ");
            string s = Console.ReadLine();
            int so_171 = int.Parse(s), gan_171 = 0;
            if(so_171 <= 0)
            {
                Console.Write("nhập sai\n");
                goto nhap;
            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= so_171; i++)
                {

                    if (so_171 % i == 0)
                    {
                        sum += 1;
                        gan_171 = i;
                    }
                }
                if (sum == 2)
                {
                    
                    Console.Write("{0} là số nguyên tố", gan_171);
                }
                else
                {
                    Console.Write("{0} không phải số nguyên tố\nsố nguyên tố gần nhất: ", gan_171);
                    for (int i = so_171; i > 1; i--)
                    {
                        int sum1 = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                sum1 += 1;
                            }
                        }
                        if (sum1 == 2)
                        {
                            Console.Write(i + " ");
                            break;
                        }
                    }
                }
            }        
            Console.ReadKey();
        }
    }
}
