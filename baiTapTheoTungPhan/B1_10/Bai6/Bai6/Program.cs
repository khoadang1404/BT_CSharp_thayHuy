using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("nhập số thứ I: ");
            string s1_171 = Console.ReadLine();
            float a_171 = float.Parse(s1_171);
            Console.Write("nhập số thứ II: ");
            string s2_171 = Console.ReadLine();
            float b_171 = float.Parse(s2_171);

            Console.Write("nhập số thứ III: ");
            string s3_171 = Console.ReadLine();
            float c_171 = float.Parse(s3_171);

            float bien_171;
            if (a_171 > b_171)
            {
                bien_171 = a_171;
                a_171 = b_171;
                b_171 = bien_171;
            }
            if (a_171 > c_171)
            {
                bien_171 = a_171;
                a_171 = c_171;
                c_171 = bien_171;
            }
            if (b_171 > c_171)
            {
                bien_171 = b_171;
                b_171 = c_171;
                c_171 = bien_171;
            }
            Console.Write("dãy tăng dần: {0} {1} {2}", a_171, b_171, c_171);
            Console.ReadKey();
        }
    }
}
