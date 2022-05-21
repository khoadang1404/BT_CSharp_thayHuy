using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cạnh I: ");
            string a = Console.ReadLine();
            float c1 = float.Parse(a);
            Console.Write("Nhập cạnh II: ");
            string b = Console.ReadLine();
            float c2 = float.Parse(b);
            Console.Write("Nhập cạnh III: ");
            string c = Console.ReadLine();
            float c3 = float.Parse(c);
            if(c1 <= 0 || c2 <= 0 || c3 <= 0)
            {
                Console.Write("Nhập sai độ dài các cạnh");
            }
            else 
            if(c1 + c2 > c3 && c1 + c3 > c2 && c2 + c3 > c1)
            {
                if(c1 == c2 && c2 == c3 && c1 == c3)
                {
                    Console.Write("tam giác đều");
                }
                else
                if (c1 == c2 || c2 == c3 || c1 == c3)
                {
                    if (Math.Pow(c1, 2) + Math.Pow(c2, 2) == Math.Pow(c3, 2)
                    || Math.Pow(c1, 2) + Math.Pow(c3, 2) == Math.Pow(c2, 2)
                    || Math.Pow(c2, 2) + Math.Pow(c3, 2) == Math.Pow(c1, 2))
                    {
                        Console.Write("tam giác vuông cân");
                    }
                    else
                    {
                        Console.Write("tam giác cân");
                    }
                }
                else
                if (Math.Pow(c1, 2) + Math.Pow(c2, 2) == Math.Pow(c3, 2) 
                    || Math.Pow(c1, 2) + Math.Pow(c3, 2) == Math.Pow(c2, 2)
                    || Math.Pow(c2, 2) + Math.Pow(c3, 2) == Math.Pow(c1, 2))
                {
                    Console.Write("tam giác vuông");
                }
                else
                {
                    Console.Write("tam giác thường");
                }
                float p = (c1 + c2 + c3) / 2;
                float S = (float)Math.Round(Math.Sqrt(p * (p - c1) * (p - c2) * (p - c3)), 3);
                Console.Write("\nDiện tích tam giác là: {0}", S);
            }
            else
            {
                Console.Write("không phải là 3 cạnh 1 tam giác");
            }                  
            Console.ReadKey();
        }
    }
}
