using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDanCu
{
    class Nguoi
    {
        private string hoten;
        private string nghenghiep;
        private string cmnd;
        private int tuoi;

        public Nguoi(string hoten, string nghenghiep, string cmnd, int tuoi)
        {
            this.hoten = hoten;
            this.nghenghiep = nghenghiep;
            this.cmnd = cmnd;
            this.tuoi = tuoi;
        }

        public Nguoi()
        {
            hoten = "";
            nghenghiep = "";
            cmnd = "";
            tuoi = 0;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void nhapNguoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Nhập vào thông tin: ");
            Console.Write("Nhập vào họ tên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập vào tuổi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập vào nghề nghiệp: ");
            nghenghiep = Console.ReadLine();
            Console.Write("Nhập vào CMND : ");
            cmnd = Console.ReadLine();
            Console.WriteLine("-------------------------");
        }

        public void inNguoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Họ tên: " + hoten);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Nghề nghiệp: " + nghenghiep);
            Console.WriteLine("CMND: " + cmnd);
            Console.WriteLine("-------------------------");
        }

    }

    class Hogiadinh
    {
        private string diachi;
        private List<Nguoi> dsNguoi = new List<Nguoi>();
        private int soTV;

        public string Diachi { get => diachi; set => diachi = value; }
        internal List<Nguoi> DsNguoi { get => dsNguoi; set => dsNguoi = value; }
        public int SoTV { get => soTV; set => soTV = value; }

        public Hogiadinh(string diachi, List<Nguoi> dsNguoi, int soTV)
        {
            this.diachi = diachi;
            this.dsNguoi = dsNguoi;
            this.soTV = soTV;
        }
        public Hogiadinh()
        {
            diachi = "";
            dsNguoi = new List<Nguoi>(0);
            soTV = 0;
        }
        public void nhapHoGD()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập vào địa chỉ: ");
            diachi = Console.ReadLine();
            Console.Write("Nhập vào số lượng thành viên trong hộ: ");
            soTV = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                Console.WriteLine("Nhập người thứ {0}: ", i + 1);
                Nguoi nguoi = new Nguoi();
                nguoi.nhapNguoi();
                //Nguoi obj = dsNguoi.Find(x => (x.Hoten == nguoi.Hoten));
                if (dsNguoi != null && dsNguoi.Any(x => x.Cmnd == nguoi.Cmnd))
                {
                    Console.WriteLine("Nhập người thứ {0} đã trùng CMND, vui lòng nhập lại! ", i + 1);
                }
                else
                {
                    dsNguoi.Add(nguoi);
                    i++;
                }
            } while (i < soTV);
            Console.WriteLine("--------------------");
        }

        public void inHoGD()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Địa chỉ: " + diachi);
            Console.WriteLine("Danh sách thành viên: ");
            foreach (var item in dsNguoi)
            {
                item.inNguoi();
            }
        }

    }

    class KhuPho
    {
        private List<Hogiadinh> dsHGD = new List<Hogiadinh>();
        private ArrayList dsCMND = new ArrayList(0);
        private int soHGD;
        private string tenKhuPho;


        public KhuPho()
        {
            dsHGD = new List<Hogiadinh>(0);
            soHGD = 0;
            tenKhuPho = "";
        }

        public KhuPho(List<Hogiadinh> dsHGD, int soHGD, string tenKhuPho)
        {
            this.dsHGD = dsHGD;
            this.soHGD = soHGD;
            this.tenKhuPho = tenKhuPho;
        }

        public int SoHGD { get => soHGD; set => soHGD = value; }
        public string TenKhuPho { get => tenKhuPho; set => tenKhuPho = value; }
        internal List<Hogiadinh> DsHGD { get => dsHGD; set => dsHGD = value; }

        public void nhapKhuPho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập vào tên khu phố: ");
            tenKhuPho = Console.ReadLine();
            Console.Write("Nhập vào số hộ dân: ");
            soHGD = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soHGD; i++)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Nhập vào hộ gia đình thứ {0}: ", i + 1);
                Hogiadinh hogiadinh = new Hogiadinh();
                hogiadinh.nhapHoGD();
                foreach (var item in hogiadinh.DsNguoi)
                {
                    if (dsCMND.Contains(item.Cmnd) && dsCMND != null)
                    {
                        Console.WriteLine("Người tên '{0}' đã trùng CMND, vui lòng nhâp lại! ", item.Hoten);
                        i--;
                        break;
                    }
                    else
                    if (item == hogiadinh.DsNguoi.Last())
                    {
                        foreach (var ds in hogiadinh.DsNguoi)
                        {
                            dsCMND.Add(ds.Cmnd);
                        }
                        dsHGD.Add(hogiadinh);
                    }
                }

            }
        }

        public void inKhuPho()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Khu phố {0} : ", tenKhuPho);
            Console.WriteLine("Số hộ gia đình {0} :", soHGD);
            foreach (var item in dsHGD)
            {
                item.inHoGD();
            }
        }

    }


    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            KhuPho khuPho = new KhuPho();
            khuPho.nhapKhuPho();
            khuPho.inKhuPho();
            Console.ReadKey();
        }
    }
}
