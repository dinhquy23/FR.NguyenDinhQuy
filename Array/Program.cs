using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Nhập và hiển thị mảng
            int[] Array1 = new int[20];
            int n, index;
            Console.WriteLine($"Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            NhapMang(Array1, n);
            Console.Write($"\nMang vua nhap: ");
            HienThiMang(Array1, n);
            //  Sắp xếp mảng tăng dần
            SapXepTangDan(Array1, n);
            Console.Write($"\nMang khi sap xep tang dan: ");
            HienThiMang(Array1, n);
            //  Sắp xếp mảng giảm dần
            SapXepGiamDan(Array1, n);
            Console.Write($"\nMang su khi sap xep giam dan: ");
            HienThiMang(Array1, n);
            //  Xoá một phần tử trong mảng
            Console.WriteLine($"\nNhap vi tri phan tu can xoa: ");
            index = int.Parse(Console.ReadLine());
            XoaMotPhanTuKhoiMang(Array1, ref n, index);
            Console.Write($"\nMang sau khi xoa phan tu thu {index}: ");
            HienThiMang(Array1, n);
            //  Nhập và hiển thị mảng thứ 2
            int[] Array2 = new int[20];
            Console.WriteLine($"\nNhap mang thu 2: ");
            NhapMang(Array2, n);
            Console.WriteLine($"Mang vua nhap: ");
            HienThiMang(Array2 , n);
            //  So sánh 2 mảng
            if (SoSanh2Mang(Array1, Array2))
            {
                Console.WriteLine($"\nHai mang giong nhau");
            }
            else
            {
                Console.WriteLine($"Hai mang khong giong nhau");
            }
            //
            Console.ReadKey();
        }

        private static bool SoSanh2Mang(int[] array1, int[] array2)
        {
            for(int i = 0; i < array1.Length; i++)
            {
                if(array1[i] != array2[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Xoá một phần tử tại vị tri được nhập từ bàn phím
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <param name="index"></param>
        private static void XoaMotPhanTuKhoiMang(int[] array, ref int n, int index)
        {
            for(int i = index-1; i < n; i++)
            {
                array[i]=array[i+1];
            }
            n--;
        }

        /// <summary>
        /// Sử dụng phương pháp nổi bọt sắp xếp mảng tăng dần
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        private static void SapXepTangDan(int[] array, int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Sử dụng phương pháp nổi bọt sắp xếp mảng giảm dần
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        private static void SapXepGiamDan(int[] array, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// Nhập mảng từ bàn phím
        /// </summary>
        /// <param name="array">Nơi chứa các phần tử được nhập</param>
        /// <param name="n">Số lượng các phần tử</param>
        private static void NhapMang(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        /// <summary>
        /// Hiển thị mảng vừa nhập từ bàn phím
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        private static void HienThiMang(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array[i]}  ");
            }
        }

    }
}
