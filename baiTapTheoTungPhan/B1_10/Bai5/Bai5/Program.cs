using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tọa độ điểm A: ");
            string xA = Console.ReadLine();
            float xA_171 = float.Parse(xA);
            string yA = Console.ReadLine();
            float yA_171 = float.Parse(yA);

            Console.Write("Nhập tọa độ điểm B: ");
            string xB = Console.ReadLine();
            float xB_171 = float.Parse(xB);
            string yB = Console.ReadLine();
            float yB_171 = float.Parse(yB);

            Console.Write("Nhập tọa độ điểm C: ");
            string xC = Console.ReadLine();
            float xC_171 = float.Parse(xC);
            string yC = Console.ReadLine();
            float yC_171 = float.Parse(yC);

            Console.Write("Nhập tọa độ điểm M: ");
            string xM = Console.ReadLine();
            float xM_171 = float.Parse(xM);
            string yM = Console.ReadLine();
            float yM_171 = float.Parse(yM);
            /*Nếu tổng diện tích của 3 tam giác này lớn hơn diện tích tam giác ABC tức là 
                điểm M nằm bên ngoài tam giác ABC. Nếu một trong ba tam giác MAB, MAC, MBC 
                có diện tích bằng 0 nghĩa là điểm M nằm trên cạnh của tam giác ABC.
                Ngoài hai trường hợp trên, chúng ta kết luận điểm M nằm bên trong tam giác ABC.*/

            float sABC_171 = (float)1.0 / 2 * Math.Abs(xA_171 * (yB_171 - yC_171) - yA_171 * (xB_171 - xC_171) + (xB_171 * yC_171 - xC_171 * yB_171));
            float sMAB_171 = (float)1.0 / 2 * Math.Abs(xM_171 * (yA_171 - yB_171) - yM_171 * (xA_171 - xB_171) + (xA_171 * yB_171 - xB_171 * yA_171));
            float sMAC_171 = (float)1.0 / 2 * Math.Abs(xM_171 * (yA_171 - yC_171) - yM_171 * (xA_171 - xC_171) + (xA_171 * yC_171 - xC_171 * yA_171));
            float sMBC_171 = (float)1.0 / 2 * Math.Abs(xM_171 * (yB_171 - yC_171) - yM_171 * (xB_171 - xC_171) + (xB_171 * yC_171 - xC_171 * yB_171));
            
            if((sMAB_171 + sMAC_171 + sMBC_171) > sABC_171)
            {
                Console.Write("M nằm ngoài tam giác ABC");
            }
            else if (sMAB_171 == 0 || sMAC_171 == 0 || sMBC_171 == 0)
            {
                Console.Write("M nằm trên cạnh tam giác ABC");
            }
            else
            {
                Console.Write("M nằm trong tam giác ABC");
            }
            Console.ReadKey();
        }
    }
}
