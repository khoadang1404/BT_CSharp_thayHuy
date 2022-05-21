using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập diện tích hình cầu: ");
            string a = Console.ReadLine();
            float Scau = float.Parse(a);
            if(Scau <= 0)
            {
                Console.Write("nhập sai diện tích hình cầu");
            }
            else
            {
                float Rcau = (float)Math.Sqrt(Scau / (4 * Math.PI));
                float Vcau = (float)Math.Round((4 * Math.PI * Math.Pow(Rcau, 3) / 3), 4);
                Console.Write("thể tích hình cầu là: {0}", Vcau);
            }
            Console.ReadKey();
        }
    }
}
