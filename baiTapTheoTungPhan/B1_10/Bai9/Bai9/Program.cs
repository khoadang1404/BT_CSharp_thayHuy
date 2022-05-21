using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void tinhCos(float sdg_phut)
        {
            float degree = sdg_phut / 60;
            Console.Write("độ tương ứng: {0}\n", degree);
            float pos_circle = (float)Math.Ceiling((degree /90) % 4);
            Console.Write("thuộc cung tròn số {0}\n", pos_circle);
            float calCos = (float)Math.Round(Math.Cos(Math.PI * degree / 180), 4);
            Console.Write("giá trị cos của {0} là: {1}", degree, calCos);

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhaplai:
            Console.Write("nhập số đo x của góc (phút): ");
            string phut = Console.ReadLine();
            float sdg_phut = float.Parse(phut);
            if(sdg_phut < 0)
            {
                Console.Write("wrong value, please insert agian");
                goto nhaplai;
            }
            else
            {
                tinhCos(sdg_phut);
            }
            Console.ReadKey();
        }
    }
}
