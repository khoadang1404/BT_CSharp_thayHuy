using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập a và b: ");
            string d1 = Console.ReadLine();
            float a_171 = float.Parse(d1);
            string d2 = Console.ReadLine();
            float b_171 = float.Parse(d2);
            if(a_171 == 0 && b_171 == 0)
            {
                Console.Write("Vô số nghiệm");
            }
            else if(a_171 == 0 && b_171 != 0)
            {
                Console.Write("Vô nghiệm");
            }
            else
            {
                float x_171 = (float)Math.Round(-b_171 / a_171, 3);
                Console.Write("phương trình có nghiệm: {0}", x_171);
            }
            
            Console.ReadKey();
        }
    }
}
