using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6_Chuong3part1
{
    class SinhVien
    {
        public string MaSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLT;
        private double DiemCSDL;
        private double DiemTB;
        
        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 2000;
            DiemCSDL = DiemLT = DiemTB = 0;
        }

        public SinhVien(string MaSV, string HoTen, int NamSinh, double DiemLT, double DiemCSDL)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
            this.DiemTB = (DiemCSDL + DiemLT) / 2;
        }

        public void NhapSV()
        {
            Console.WriteLine("nhap thong tin sinh vien ");
            Console.WriteLine("ho ten la: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("ma sinh vien la: ");
            MaSV = Console.ReadLine();
            Console.WriteLine("nam sinh la: ");
            NamSinh = Int32.Parse(Console.ReadLine());
            Console.WriteLine("diem lap trinh la: ");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("diem co so du lieu la: ");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());
        }
        
        public void tinhdiem()
        {
            DiemTB = (0.5 * (DiemCSDL + DiemLT));
        }

        public void XuatSV()
        {
            Console.WriteLine("thong tin sinh vien \n ma sinh vien la: {0}\n ho ten la: {1}\n nam sinh la: {2} \n diem lap trinh la: {3} \n diem co so du lieu la: {4} \n diem tring binh la: {5} ", MaSV, HoTen, NamSinh, DiemLT, DiemCSDL, DiemTB);
        }

        public bool checkdiem()
        {
            bool Diem = false;
            if (DiemTB > 8.5) Diem = true;
            return Diem;
        }
    }
}
