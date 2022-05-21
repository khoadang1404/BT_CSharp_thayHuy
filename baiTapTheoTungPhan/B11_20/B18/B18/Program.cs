using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        nhap:
            Console.Write("nhập số giờ: ");
            string hour = Console.ReadLine();
            int hours_171 = int.Parse(hour);
            if (hours_171 < 0)
            {
                Console.Write("nhập sai\n");
                goto nhap;
            }
            else
            {
                int day_171 = hours_171 / 24;
                int exhours_171 = hours_171 % 24;
                int week_171 = day_171 / 7;
                int exday_171 = day_171 % 7;
                Console.Write("{0} tuần, {1} ngày, {2} giờ", week_171, exday_171, exhours_171);
            }
            Console.ReadKey();
        }
    }
}
