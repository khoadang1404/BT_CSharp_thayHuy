using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập x của điểm A: ");
            string d1A = Console.ReadLine();
            float xA = float.Parse(d1A);
            Console.Write("nhập y của điểm A: ");
            string d2A = Console.ReadLine();
            float yA = float.Parse(d2A);
            Console.Write("nhập x của điểm B: ");
            string d1B = Console.ReadLine();
            float xB = float.Parse(d1B);
            Console.Write("nhập y của điểm B: ");
            string d2B = Console.ReadLine();
            float yB = float.Parse(d2B);
            float distanceAB = (float)Math.Round(Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)), 3);
            Console.Write("Khoảng cách của 2 điểm A và B là {0}", distanceAB);

            Console.ReadKey();
        }
    }
}
