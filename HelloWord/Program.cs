using System;
using System.Collections.Generic;

namespace ToanTu
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //int i, pos, n; //pos la vi tri can xoa
            //int[] arr1 = new int[50];


            //Console.Write("\nXoa phan tu trong mang C#:\n");
            //Console.Write("---------------------------\n");

            //Console.Write("Nhap kich co mang: ");
            //n = Convert.ToInt32(Console.ReadLine());
            ///* nhap cac phan tu vao trong mang*/
            //Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("Phan tu - {0}: ", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("\nNhap vi tri can xoa: ");
            //pos = Convert.ToInt32(Console.ReadLine());
            ///* xac dinh vi tri cua i trong mang*/
            //i = 0;
            //while (i != pos - 1)
            //    i++;
            ///*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            //while (i < n)
            //{
            //    arr1[i] = arr1[i + 1];
            //    i++;
            //}
            //n--;
            //Console.Write("\nIn mang sau khi da xoa phan tu: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("  {0}", arr1[i]);
            //}
            //Console.Write("\n\n");

            //Console.ReadKey();


            //PhanSo ps1 = new PhanSo(1,2);
            //PhanSo ps2 = new PhanSo(2,4);
            //ps.NhapPhanSo();
            //Console.Write(ps.XuatPhanSo());
            //ps.RutGonPhanSo();
            //Console.Write(ps.XuatPhanSo());
            //ps = ps1 * ps2;
            //Console.WriteLine(ps.ToString());
            //if (ps1 > ps2)
            //{
            //    Console.WriteLine($"ps1 lon hon ps 2");
            //}
            //if (ps1 < ps2)
            //{
            //    Console.WriteLine($"ps1 be hon ps2");
            //}
            //if (ps1 == ps2)
            //{
            //    Console.WriteLine($"bang nhau");
            //}
            //if (ps1 != ps2)
            //{
            //    Console.WriteLine($"khac nhau");
            //}
            List<PhanSo> listPs = new List<PhanSo>()
            {
                new PhanSo(2,3),
                new PhanSo(5,4),
                new PhanSo(1,2),
                new PhanSo(6,3),
                new PhanSo(2,5),
                new PhanSo(9,5),
                new PhanSo(1,3),
                new PhanSo(6,7),
                new PhanSo(21,4),
                new PhanSo(13,14),
            };
            string luaChon = "";
            int i = 1;
            //PhanSo ps1 = new PhanSo(1, 5);
            //PhanSo ps2 = new PhanSo(2, 5);
            //PhanSo ps3 = new PhanSo(3, 5);
            //Console.WriteLine($"ps1 + ps2 + ps3= { ps1+ps2+ps3}");
            do
            {
                Console.WriteLine($"1.  Nhap phan so moi");
                Console.WriteLine($"2.  Hien thi day phan so vua nhap");
                Console.WriteLine($"3.  Sap xep day phan so tang dan");
                Console.WriteLine($"4.  Sap xep day phan so giam dan");
                Console.WriteLine($"5.  Rut gon day phan so");
                Console.WriteLine($"6.  Cong day phan so");
                Console.WriteLine($"7.  Tru day phan so");
                Console.WriteLine($"8.  Nhan day phan so");
                Console.WriteLine($"9.  Chia day phan so");
                Console.WriteLine($"0.  Thoat!");
                luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1":
                        {
                            try
                            {
                                PhanSo ps = new PhanSo();
                                Console.WriteLine($"Nhap phan so thu {i}, nhap : ");
                                ps.NhapPhanSo();
                                listPs.Add(ps);
                                i++;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case "2":
                        {
                            if (listPs.Count > 0)
                            {
                                foreach (var item in listPs)
                                {
                                    Console.Write($"{item.ToString()} \t");
                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            SapXepDayGiamDan(listPs);

                            break;
                        }
                    case "4":
                        {
                            SapXepDayTangDan(listPs);
                            break;
                        }
                    case "5":
                        {
                            RutGonDayPhanSo(listPs);
                            break;
                        }
                    case "6":
                        Console.WriteLine($"Tong day phan so: {CongDayPhanSo(listPs)}");
                        break;
                    case "7":
                        Console.WriteLine($"Hieu day phan so: {TruDayPhanSo(listPs)}");
                        break;
                    case "8":
                        Console.WriteLine($"Tich day phan so: {NhanDayPhanSo(listPs)}");
                        break;
                    case "9":
                        Console.WriteLine($"Thuong day phan so: {ChiaDayPhanSo(listPs)}");
                        break;
                    case "0":
                        break;
                    default:
                        {
                            Console.WriteLine("Lua chon khong phu hop, hay nhap lai");
                            break;
                        }
                }
                Console.WriteLine($"\n------------------------------------");

            } while (luaChon != "0");
            Console.ReadLine();
        }
        //
        private static PhanSo ChiaDayPhanSo(List<PhanSo> listPs)
        {
            PhanSo Thuong = new PhanSo(1,1);
            foreach (var phanSo in listPs)
            {
                Thuong /= phanSo;
            }
            return Thuong;
        }
        //
        private static PhanSo NhanDayPhanSo(List<PhanSo> listPs)
        {
            PhanSo Tich = new PhanSo();
            foreach (var phanSo in listPs)
            {
                Tich *= phanSo;
            }
            return Tich;
        }
        //
        private static PhanSo TruDayPhanSo(List<PhanSo> listPs)
        {
            PhanSo Hieu = new PhanSo();
            foreach (var phanSo in listPs)
            {
                Hieu -= phanSo;
            }
            return Hieu;
        }
        //
        private static PhanSo CongDayPhanSo(List<PhanSo> listPs)
        {
            PhanSo Tong=new PhanSo();
            foreach(var phanSo in listPs)
            {
                Tong += phanSo;
            }
            return Tong;
        }
        //
        private static void RutGonDayPhanSo(List<PhanSo> listPs)
        {
            if(listPs.Count ==0)
            {
                Console.WriteLine($"Day phan so rong");
            }
            else
            {
                foreach(var item in listPs)
                {
                    item.RutGonPhanSo();
                }
            }
        }

        /// <summary>
        /// Su dung thuat toan noi bot sap xep day phan so giam dan
        /// </summary>
        /// <param name="listPs"></param>
        private static void SapXepDayGiamDan(List<PhanSo> listPs)
        {
            for (int i = 0; i < listPs.Count - 1; i++)
            {
                for (int j = i + 1; j < listPs.Count; j++)
                {
                    if (listPs[i] < listPs[j])
                    {
                        PhanSo phanSo = new PhanSo();
                        phanSo = listPs[i];
                        listPs[i] = listPs[j];
                        listPs[j] = phanSo;
                    }
                }
            }
        }
        /// <summary>
        /// Sap xep day phan so tang dan su dung thuat toan noi bot
        /// </summary>
        /// <param name="listPs"></param>
        private static void SapXepDayTangDan(List<PhanSo> listPs)
        {
            for (int i = 0; i < listPs.Count - 1; i++)
            {
                for (int j = i + 1; j < listPs.Count; j++)
                {
                    if (listPs[i] > listPs[j])
                    {
                        PhanSo phanSo = new PhanSo();
                        phanSo = listPs[i];
                        listPs[i] = listPs[j];
                        listPs[j] = phanSo;
                    }
                }
            }
        }
    }
}
