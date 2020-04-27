using System;
using System.Collections.Generic;
using System.Text;

namespace Bai6_Chuong3part1
{
    class DanhSachSinhVien
    {
        private int n;
        private SinhVien[] DS;
        private int i;
        private int j;

        public void NhapDS()
        {
            Console.WriteLine("nhap danh sach sinh vien: ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so luong sinh vien: ");
            DS = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap vao sinh vien thu {0} ", i);
                DS[i] = new SinhVien();
                DS[i].NhapSV();
            }
        }

        public void XuatDS()
        {
            if (DS != null && n > 0) ;
            Console.WriteLine("danh sach sinh vien ");
            for(int i=0; i < n; i++)
            {
                DS[i].tinhdiem();
                DS[i].XuatSV();
            }
        }

        public void DSSV()
        {
            for(int i=0; i<n; i++)
            {
                if (DS[i].checkdiem())
                {
                    Console.WriteLine("danh sach sinh vien cos diem cao hon 8.5 la: ");
                    DS[i].XuatSV();
                }
            }
        }

        public void Sapxep()
        {
            SinhVien tg;
            Console.WriteLine("danh sach sinh vien: ");
            for(int i=0; i<n; i++)
            for(int j=n-1; j>i; j--)
                {
                    if(string.Compare( DS[j-i].MaSV , DS[j].MaSV, true )>0)
                        {
                        tg = DS[j - 1];
                        DS[j - 1] = DS[j];
                        DS[j] = tg;
                    }
                }
            for(int i=0; i<n; i++)
            {
                DS[i].XuatSV();
            }
        }
    }
}
