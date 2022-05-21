using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B38
{
    class Program
    {
        static void changeMoney(int moneyChange)
        {
            if(moneyChange <= 5)
            {
                Console.Write("nhập sai yêu cầu");
            }
            else
            {
                
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số tiền (nghìn đồng và > 5): ");
            string money = Console.ReadLine();
            int moneyChange = int.Parse(money);
            changeMoney(moneyChange);
            Console.ReadKey();
        }
    }
}
