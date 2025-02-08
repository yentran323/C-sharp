using System;

namespace MaTran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so dong cua ma tran thu nhat:");
            int m1 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran thu nhat:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            MaTran a = new MaTran(m1, n1);
            Console.WriteLine("Nhap ma tran a:");
            a.NhapMaTran();
            Console.WriteLine("Ma tran a:");
            a.InMaTran();

            Console.Write("Nhap so dong cua ma tran thu hai:");
            int m2 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran thu hai:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            MaTran b = new MaTran(m2, n2);
            Console.WriteLine("Nhap ma tran b:");
            b.NhapMaTran();
            Console.WriteLine("Ma tran b:");
            b.InMaTran();

            MaTran c = new MaTran(m1, n2);
            if (m1 != m2 || n1 != n2)
                Console.WriteLine("Khong the cong 2 ma tran khong cung co");
            else
            {
                Console.WriteLine("Tong hai ma tran:");
                c = c.Tong(a, b);
                c.InMaTran();
            }

            if (m1 != m2 || n1 != n2)
                Console.WriteLine("Khong the tinh hieu 2 ma tran khong cung co");
            else
            {
                Console.WriteLine("Hieu hai ma tran:");
                c = c.Hieu(a, b);
                c.InMaTran();
            }

            if (n1 != m2)
                Console.WriteLine("Khong the nhan hai ma tran");
            else
            {
                Console.WriteLine("Tich hai ma tran:");
                c = c.Tich(a, b);
                c.InMaTran();
            }

            Console.WriteLine("Ma tran chuyen vi cua a la:");
            MaTran cv = a.MaTranChuyenVi();
            cv.InMaTran();

            if (a.KiemTraMaTranVuong())
                Console.WriteLine("Ma tran a la ma tran vuong");
            else
                Console.WriteLine("Ma tran a khong la ma tran vuong");

            Console.ReadLine();
        }
    }
}
