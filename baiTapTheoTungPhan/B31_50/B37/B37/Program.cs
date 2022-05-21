using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B37
{
    class Program
    {
        static void timMax(int so)
        {
            if(so < 0)
            {
                Console.Write("nhập sai thông tin");
            }else
            {
                int tong = 0, dem = 0, dem1 = 0;
                for(int i = 1; i <= so; i++)
                {
                    tong += i;
                    if(tong < so)
                    {
                        dem = i;
                        dem1 = tong;
                    }
                        
                }
                Console.Write("tổng từ 1 đến {0} là: {1} < {2}\n", dem, dem1, so);
                Console.Write("kết quả là: {0}", dem);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập 1 số dương: ");
            string so = Console.ReadLine();
            int sond = int.Parse(so);
            timMax(sond);
            Console.ReadKey();
        }
    }
}
