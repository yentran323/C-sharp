using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTran
{
    class MaTran
    {
        private int m; //So dong cua ma tran
        private int n; //So cot cua ma tran
        int[,] matran;

        public MaTran(int m, int n)
        {
            this.n = n;
            this.m = m;
            matran = new int[m, n];
        }
        public MaTran(int[,] maTran)
        {
            matran = new int[maTran.GetLength(0), maTran.GetLength(1)];
            for (int i = 0; i < maTran.GetLength(0); i++)
            {
                for (int j = 0; j < maTran.GetLength(1); j++)
                {
                    matran[i, j] = maTran[i, j];
                }
            }
        }

        public void NhapMaTran()
        {
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu [{0},{1}]: ", i, j);
                    matran[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void InMaTran()
        {
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    Console.Write("{0,10}", matran[i, j]);
                }
                Console.WriteLine();
            }
        }
        protected int[,] ConvertToMang2Chieu()
        {
            int[,] cv = new int[m, n];
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    cv[i, j] = matran[i, j];
                }
            }
            return cv;
        }
        public MaTran Tong(MaTran a, MaTran b)
        {
            int [,] mt1 = a.ConvertToMang2Chieu();
            int[,] mt2 = b.ConvertToMang2Chieu();
            int[,] ketqua = new int[a.m, a.n];

            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    ketqua[i, j] = mt1[i, j] + mt2[i, j];
                }
            }
            MaTran kq = new MaTran(ketqua);
            return kq;
        }
        public MaTran Hieu(MaTran a, MaTran b)
        {
            int[,] mt1 = a.ConvertToMang2Chieu();
            int[,] mt2 = b.ConvertToMang2Chieu();
            int[,] ketqua = new int[a.m, a.n];

            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    ketqua[i, j] = mt1[i, j] + (-1)*mt2[i, j];
                }
            }
            MaTran kq = new MaTran(ketqua);
            return kq;
        }

        public MaTran Tich(MaTran a, MaTran b)
        {
            int[,] mt1 = a.ConvertToMang2Chieu();
            int[,] mt2 = b.ConvertToMang2Chieu();
            int[,] ketqua = new int[a.m, b.n];

            for (int i = 0; i < a.m; i++) //hang cua ma tran a
            {
                for (int j = 0; j < b.n; j++) // cot cua ma tran b
                {
                    int tong = 0;
                    for (int k = 0; k < a.n; k++) 
                    {
                        tong += mt1[i, k] * mt2[k, j];
                    }
                    ketqua[i, j] = tong;
                }
            }
            MaTran kq = new MaTran(ketqua);
            return kq;
        }
        public MaTran MaTranChuyenVi()
        {
            int[,] cv = new int[n, m];
            for (int i = 0; i < matran.GetLength(0); i++)
            {
                for (int j = 0; j < matran.GetLength(1); j++)
                {
                    cv[j, i] = matran[i, j];
                }
            }
            MaTran kq = new MaTran(cv);
            return kq;
        }
        public bool KiemTraMaTranVuong()
        {
            bool kt = false;
            if (m == n) kt = true;
            return kt;
        }
    }
}
