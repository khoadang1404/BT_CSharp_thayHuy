using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void tinhPTBac2(float a, float b, float c)
        {
            float delta = (float)Math.Pow(b, 2) - 4 * a * c;
            Console.Write("delta = {0}\n", delta);
            if(delta < 0)
            {
                Console.Write("Phương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                float x = (float)Math.Round(-b / (2 * a), 3);
                Console.Write("phương trình có nghiệm kép: {0}", x);
            }
            else
            {
                float x1 = (float)Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 3);
                float x2 = (float)Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 3);
                Console.Write("Phương trình có 2 nghiệm: {0} và {1}", x1, x2);
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhaplai:
            Console.Write("nhập lần lượt a, b, c: ");
            string b1 = Console.ReadLine();
            string b2 = Console.ReadLine();
            string b3 = Console.ReadLine();
            float a = float.Parse(b1);
            float b = float.Parse(b2);
            float c = float.Parse(b3);
            if (a == 0)
            {
                Console.Write("không phải phương trinh bậc 2");
                goto nhaplai;
            }
            else
            {
                tinhPTBac2(a, b, c);
            }
            Console.ReadKey();
        }
    }
}
