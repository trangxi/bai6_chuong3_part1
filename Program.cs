using System;

namespace Bai6_Chuong3part1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien SinhVien1 = new SinhVien();
            SinhVien1.NhapSV();
            SinhVien1.tinhdiem();
            SinhVien1.XuatSV();
            Console.ReadLine();
            DanhSachSinhVien danhSachSinhVien1 = new DanhSachSinhVien();
            danhSachSinhVien1.NhapDS();
            danhSachSinhVien1.XuatDS();
            Console.WriteLine("sinh vien co diem tren 8.5");
            danhSachSinhVien1.DSSV();
            danhSachSinhVien1.Sapxep();
            Console.Read();


        }
    }
}
