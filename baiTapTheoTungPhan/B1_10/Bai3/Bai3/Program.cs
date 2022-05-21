using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập tọa độ x, y tâm C: ");
            string d1 = Console.ReadLine();
            float xC = float.Parse(d1);
            string d2 = Console.ReadLine();
            float yC = float.Parse(d2);

            Console.Write("nhập bán kính R: ");
            string bkinh = Console.ReadLine();
            float R = float.Parse(bkinh);

            Console.Write("nhập tọa độ x, y điểm M: ");
            string d1M = Console.ReadLine();
            float xM = float.Parse(d1M);
            string d2M = Console.ReadLine();
            float yM = float.Parse(d2M);

            float kCachOM = (float)Math.Round(Math.Pow(xM - xC, 2) + Math.Pow(yM - yC, 2), 4);
            float kCachR = (float)Math.Pow(R, 2);
            if(R <= 0)
            {
                Console.Write("nhập sai độ dài bán kính");
            }
            else if(kCachOM < kCachR)
            {
                Console.Write("điểm M nằm trong đường tròn");
            }
            else if(kCachOM == kCachR)
            {
                Console.Write("điểm M nằm trên đường tròn");
            }
            else
            {
                Console.Write("điểm M nằm ngoài đường tròn");
            }
            Console.ReadLine();
        }
    }
}
