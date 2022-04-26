using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDiemDanh_1
{
    class HeSo_171
    {
        private int a;
        private int b;
        private int c;
        public HeSo_171() { }
        public HeSo_171(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A_171 { 
            get => a; 
            set => a = value;
        }
        public int B_171 { 
            get => b; 
            set => b = value; 
        }
        public int C_171 { 
            get => c; 
            set => c = value;
        }


        public double Delta_171(int a, int b, int c)
        {

            return b * b - 4 * a * c;
        }
        public void Nghiem_171(int a, int b, int c)
        {
            double del = Delta_171(a, b, c);
            if (del == 0)
                Console.WriteLine("Phương trình 1 nghiệm x: {0}", -b / 2 * a);
            else if (del > 0)
            {
                double x1 = (-b + Math.Sqrt(del)) / (2 * a);
                double x2 = (-b - Math.Sqrt(del)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else
                Console.WriteLine("Phương trình vô nghiệm");

        }
        class Program
        {
            static void Main(string[] args)
            {

            }
        }
    }
}
