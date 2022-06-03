using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyBanVeMayBay
{
    class Vemaybay
    {
        private string tenchuyen;
        private string ngaybay;
        private int giave;

        public int getGiave { get => giave; set => giave = value; }

        public Vemaybay(string tenchuyen, string ngaybay, int giave)
        {
            this.tenchuyen = tenchuyen;
            this.ngaybay = ngaybay;
            this.giave = giave;
        }

        public Vemaybay()
        {
            tenchuyen = "";
            ngaybay = "";
            giave = 0;
        }
        ~Vemaybay()
        {
            tenchuyen = "";
            ngaybay = "";
            giave = 0;
        }
        public void nhapVe()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("\nNhập vào tên chuyến bay: ");
            tenchuyen = Console.ReadLine();
            Console.Write("Nhập vào ngày bay: ");
            ngaybay = Console.ReadLine();
            Console.Write("Nhập giá vé: ");
            giave = Convert.ToInt32(Console.ReadLine());
        }

        public void xuatVe()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tên chuyến bay: " + tenchuyen);
            Console.WriteLine("Ngày bay: " + ngaybay);
            Console.WriteLine("Giá vé: {0}\n", giave);
        }


    }

    class Nguoi
    {
        private string ten;
        private string gioitinh;
        private int tuoi;

        public Nguoi(string ten, string gioitinh, int tuoi)
        {
            this.ten = ten;
            this.gioitinh = gioitinh;
            this.tuoi = tuoi;
        }

        public Nguoi()
        {
            ten = "";
            gioitinh = "";
            tuoi = 0;
        }
        ~Nguoi()
        {
            ten = "";
            gioitinh = "";
            tuoi = 0;
        }
        public void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập vào tên khách hàng: ");
            ten = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhập số tuổi: ");
            tuoi = Convert.ToInt32(Console.ReadLine());
        }

        public void xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tên: " + ten);
            Console.WriteLine("Tuổi: " + tuoi);
            Console.WriteLine("Giới tính: " + gioitinh);
        }

    }

    class HanhKhach : Nguoi
    {
        Vemaybay[] Vemaybay;
        int soluong;
        int tongtien;

        public HanhKhach()
        {
            soluong = 0;
            Vemaybay = new Vemaybay[soluong];
            tongtien = 0;
        }
        ~HanhKhach()
        {
            soluong = 0;
            Vemaybay = new Vemaybay[soluong];
            tongtien = 0;
        }

        public int Tongtien { get => tongtien; set => tongtien = value; }

        public void nhapKhach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            nhap();
            Console.Write("Nhập vào số lượng vé mà hành khách đã mua: ");
            soluong = Convert.ToInt32(Console.ReadLine());
            Vemaybay = new Vemaybay[soluong];
            for (int i = 0; i < soluong; i++)
            {
                Vemaybay[i] = new Vemaybay();
                Vemaybay[i].nhapVe();
                tongtien += Vemaybay[i].getGiave;
            }
        }

        public void xuatKhach()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("------------------------");
            Console.WriteLine("THÔNG TIN KHÁCH HÀNG: ");
            xuat();
            Console.WriteLine("\nTHÔNG TIN CHUYẾN BAY: ");
            for (int i = 0; i < soluong; i++)
            {
                Vemaybay[i].xuatVe();
            }
            Console.Write("Tổng tiền: {0}\n", tongtien);

        }

        public static bool operator <(HanhKhach obj1, HanhKhach obj2)
        {
            if (obj1.tongtien < obj2.tongtien) return true;
            else return false;
        }
        public static bool operator >(HanhKhach obj1, HanhKhach obj2)
        {
            if (obj1.tongtien > obj2.tongtien) return true;
            else return false;
        }
    }

    class Program
    {
        public static void swap(ref HanhKhach a, ref HanhKhach b)
        {
            HanhKhach temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void Bubblesort(HanhKhach[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        swap(ref arr[j], ref arr[j + 1]);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            int soLuongHK;
            Console.Write("Nhập vào số lượng hành khách: ");
            soLuongHK = Convert.ToInt32(Console.ReadLine());
            HanhKhach[] HK = new HanhKhach[soLuongHK];
            for (int i = 0; i < soLuongHK; i++)
            {
                Console.Write("Nhập vào hành khách thứ {0}:\n", i + 1);
                HK[i] = new HanhKhach();
                HK[i].nhapKhach();
            }
            Bubblesort(HK, soLuongHK);
            for (int i = 0; i < soLuongHK; i++)
            {
                HK[i].xuatKhach();
                Console.WriteLine("--------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
