using System;
using System.Collections.Generic;
using System.Text;

namespace Vd1_Chuong3
{
    class HinhChuNhat
    {
        private float dai, rong;

        public void nhap()
        {
            Console.Write("Nhap chieu dai hinh chu nhat: ");
            dai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong hinh chu nhat: ");
            rong = float.Parse(Console.ReadLine());
        }
        public float chuvi()
        {
            return (dai + rong) * 2;
        }
        public float dientich()
        {
            return (dai * rong);
        }
        public HinhChuNhat(float _dai, float _rong)
        {
            dai = _dai;
            rong = _rong;
        }
        public HinhChuNhat()
        {
            dai = rong = 1;
        }
        public HinhChuNhat (HinhChuNhat h)
        {
            dai = h.dai;
            rong = h.rong;
        }
        public HinhChuNhat(int dai, int rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
    }
}
