using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n_171;
            string[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            Console.Write("Nhap n = ");
            n_171 = int.Parse(Console.ReadLine());
            Console.Write("Nam {0} - {1} {2}", n_171, can[n_171 % 10], chi[n_171 % 12]);
            Console.WriteLine();
            Console.Write("Nam {0} - {1} {2}", n_171 + 60, can[n_171 % 10], chi[n_171 % 12]);
            Console.ReadKey();
        }
    }
}
