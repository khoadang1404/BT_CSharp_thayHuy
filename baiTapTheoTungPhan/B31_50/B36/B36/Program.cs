using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhap:
            Console.Write("nhập 1 số: ");
            string so = Console.ReadLine();
            int so_171 = int.Parse(so);
            if(so_171 <= 0)
            {
                Console.Write("nhập sai\n");
                goto nhap;
            }
            else
            {
                Console.Write("{0} số nguyên tố: ", so_171);
                int count = 0;
                int m = 2;
                while(count < so_171)
                {
                    int mark = 1;
                    //xét trong khoản 2 --> m, có giá trị % i ==  --> bỏ
                    //ở đây nếu để i <= m --> sai ngay vì i = m = 2 và lặp vô tận (i luôn <= m)
                    for(int i = 2; i * i <= m; i++)
                    {
                        if(m % i == 0)
                        {
                            mark = 0;
                            break;
                        }
                    }
                    // kiểm tra mark còn == 1 không? còn thì in m ra
                    if(mark == 1)
                    {
                        count += 1;
                        Console.Write(m + " ");
                    }
                    m++;
                }
            }
            Console.ReadKey();
        }
    }
}
