using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập ngày, tháng, năm: ");
            string ngay = Console.ReadLine();
            int day_171 = int.Parse(ngay);
            string thang = Console.ReadLine();
            int month_171 = int.Parse(thang);
            string nam = Console.ReadLine();
            int year_171 = int.Parse(nam);
            if(year_171 < 1582)
            {
                Console.Write("lịch Gregorian bắt đầu từ năm 1582");
            }
            else
            if(month_171 < 1 || month_171 > 12)
            {
                Console.Write("nhập tháng sai");
            }
            else
            {
                int top;
                switch (month_171)
                {
                    case 4:
                        top = 30;
                        break;
                    case 6:
                        top = 30;
                        break;
                    case 9:
                        top = 30;
                        break;
                    case 11:
                        top = 30;
                        break;
                    case 2:
                        if (year_171 % 4 == 0 && year_171 % 100 != 0)
                        {
                            top = 29;
                        }
                        else
                        {
                            top = 28;
                        }
                        break;
                    default:
                        top = 31;
                        break;
                }
                if (day_171 < 1 || day_171 > top)
                {
                    Console.Write("nhập sai ngày, nhập lại");
                }
                else
                {
                    Console.Write("ngày tháng năm hợp lệ\n");
                    int a_171 = (14 - month_171) / 12;
                    int y_171 = year_171 - a_171;
                    int m_171 = month_171 + 12 * a_171 - 2;
                    int dayOfWeek_171 = (day_171 + y_171 + y_171 / 4 - y_171 / 100
                        + y_171 / 400 + (31 * m_171) / 12) % 7;
                    Console.Write("là thứ {0}", dayOfWeek_171 + 1);
                }
            }
            Console.ReadKey();
        }
    }
}
