using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập a1, b1, c1: ");
            string a1 = Console.ReadLine();
            float a1_171 = float.Parse(a1);
            string b1 = Console.ReadLine();
            float b1_171 = float.Parse(b1);
            string c1 = Console.ReadLine();
            float c1_171 = float.Parse(c1);

            Console.Write("nhập a2, b2, c2: ");
            string a2 = Console.ReadLine();
            float a2_171 = float.Parse(a2);
            string b2 = Console.ReadLine();
            float b2_171 = float.Parse(b2);
            string c2 = Console.ReadLine();
            float c2_171 = float.Parse(c2);

            float D_171 = a1_171 * b2_171 - a2_171 * b1_171;
            if(D_171 != 0)
            {
                Console.WriteLine("Thỏa công thức Cramer");
                float Dx_171 = (float)Math.Round(c1_171 * b2_171 - b1_171 * c2_171, 3);
                float Dy_171 = (float)Math.Round(a1_171 * c2_171 - a2_171 * c1_171, 3);
                float x_171 = Dx_171 / D_171;
                float y_171 = Dy_171 / D_171;
                Console.Write("Giá trị x và y: {0}, {1}", x_171, y_171);
            }
            else
            {
                Console.WriteLine("Không thỏa công thức Cramer");
            }
            Console.ReadKey();
        }
    }
}
