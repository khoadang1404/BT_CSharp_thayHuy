using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapDiemDanh
{
    internal class Program
    {
        public class Animal_171
        {

            //public double Weight;
            //public double Height;

            public void Eat_171()
            {
                Console.WriteLine("đang ăn");
            }
            public void MakeSound()
            {
                Console.WriteLine("đang phát ra tiếng kêu");
            }
        }
        class Cat:Animal_171
        {
            public void Run_171()
            {
                Console.WriteLine("Mèo đang chạ");
            }
            Animal_171 animal = new Animal_171();

        }
        class Bird:Animal_171
        {
            public void Fly_171()
            {
                Console.WriteLine("Chym đang bay");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cat cat_171 = new Cat();    
            cat_171.Run_171();  
            cat_171.Eat_171();
            cat_171.MakeSound();
            Bird bird_171 = new Bird(); 
            bird_171.Fly_171(); 
            bird_171.Eat_171();
            bird_171.MakeSound();
            Console.ReadKey(); 
        }
    }
}
