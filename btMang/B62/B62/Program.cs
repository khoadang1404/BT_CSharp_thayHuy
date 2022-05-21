using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B62
{
    internal class Program
    {
        static int ucln(int a, int b)
        {
            if (b == 0) 
                return a;
            if (a % b == 0) 
                return b;
            return ucln(b, a % b);
        }
        static void delete_MatchValue(int[] a, ref int n)
        {
            for (int i = 0; i < n - 1; i++)  // 1 2 1 1
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        for (int t = j; t < n; t++)
                        {
                            a[t] = a[t + 1];
                        }
                        j--;
                        n--;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int n_171;
            int s1_171 = 0, s2_171 = 0;
            int[] a = new int[100];
            do
            {
                Console.Write("nhap n > 0: ");
                n_171 = Convert.ToInt32(Console.ReadLine());
            } while (n_171 <= 0);
            Random ran = new Random();
            for (int i = 0; i < n_171; i++)
            {
                a[i] = ran.Next(10, 20);
                if (a[i] % 2 == 0 && i % 2 != 0)
                {
                    s1_171 += a[i];
                }
                if (a[i] % 2 != 0 && i % 2 == 0)
                {
                    s2_171 += a[i];
                }
                Console.Write(a[i] + " ");
            }
            Console.Write("\nTong so chan o vi tri le: " + s1_171);
            Console.Write("\nTong so le o vi tri chan: " + s2_171);
            if (s1_171 == s2_171)
            {
                Console.Write("\nBang nhau");
            }
            else
            {
                Console.Write("\nKhac nhau");
            }
            delete_MatchValue(a, ref n_171);
            Console.Write("\nCac cap nguyen to cung nhau:\n");
            for (int i = 0; i < n_171 - 1; i++)
            {
                for (int j = i + 1; j < n_171; j++)
                {
                    if (ucln(a[i], a[j]) == 1)
                    {
                        Console.WriteLine("({0},{1})", a[i], a[j]);
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
