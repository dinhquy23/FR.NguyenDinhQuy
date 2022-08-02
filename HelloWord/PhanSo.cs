using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTu
{
    public class PhanSo
    {
        int _mauSo;
        public int TuSo { get; set; }
        public int MauSo
        {
            get { return _mauSo; }
            set
            {
                try
                {
                    if (value == 0)
                    {
                        Exception MauBangKhong = new Exception("Mau phai khac 0");
                        throw MauBangKhong;
                    }
                    else
                    {
                        this._mauSo = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw e;
                }
            }
        }
        //
        public PhanSo() 
        {
            TuSo = 0;
            MauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        /// <summary>
        /// 
        /// </summary>
        public void NhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            this.TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            this.MauSo = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (MauSo < 0)
            {
                TuSo = TuSo * (-1);
                MauSo = MauSo * (-1);
            }
            return $"{this.TuSo}/{this.MauSo}";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tuso"></param>
        /// <param name="mauso"></param>
        /// <returns></returns>
        public int UCLN(int tuso, int mauso)
        {
            if (tuso % mauso != 0)
            {
                return UCLN(mauso, tuso % mauso);
            }
            else
            {
                return mauso;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void RutGonPhanSo()
        {
            int c = UCLN(TuSo, MauSo);
            TuSo = TuSo / c;
            MauSo = MauSo / c;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            return ps;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            return ps;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.TuSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            return ps;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo, a.MauSo * b.TuSo);
            ps.RutGonPhanSo();
            return ps;
        }

        public static bool operator >(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            if(ps.TuSo>0)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            if (ps.TuSo < 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            if (ps.TuSo == 0)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(PhanSo a, PhanSo b)
        {
            PhanSo ps = new PhanSo(a.TuSo * b.MauSo - b.TuSo * a.MauSo, a.MauSo * b.MauSo);
            ps.RutGonPhanSo();
            if (ps.TuSo != 0)
            {
                return true;
            }
            return false;
        }
    }
}
