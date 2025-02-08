using System;

namespace Vd1_Chuong3
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat h1 = new HinhChuNhat();
            h1.nhap();
            Console.WriteLine("Chu vi va dien tich hinh chu nhat la: " +
                "{0} va {1} ", h1.chuvi(), h1.dientich());

            //HinhChuNhat h2 = new HinhChuNhat(Convert.ToSingle(1.6), (float)2.0) ;
            //Console.WriteLine("Chu vi va dien tich hinh chu nhat h2 la: " +
            //    "{0} va {1} ", h2.chuvi(), h2.dientich());

            HinhChuNhat h4 = new HinhChuNhat(h1);
            Console.WriteLine("Chu vi va dien tich hinh chu nhat h4 khoi tao sao chep tu h1 la: " +
                "{0} va {1} ", h4.chuvi(), h4.dientich());
            HinhChuNhat h5 = new HinhChuNhat(3,5);
            Console.WriteLine("Chu vi va dien tich hinh chu nhat h5 la: " +
                "{0} va {1} ", h5.chuvi(), h5.dientich());

            Console.ReadLine();
        }
    }
}
