using System.Text;
using System.Threading.Channels;

namespace buoi_3_bai_tap
{
    internal class Program
    {
        // bài 1:
        //khai báo thuế cố định 10%
        const double VAT = 0.1;
        //nhập số lượng và đơn giá
        
        static void NhapDonGia(out double donGia, out int soLuong)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("mời nhập số lượng :");
            soLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mời nhập đơn giá :");
            donGia = Convert.ToDouble(Console.ReadLine());

        }
        //hàm tính toán thành tiền thuế VAT tổng tiền thsnh toán
        static void TinhTien(double donGia, int soLuong, out double thanhTien, out double thueVAT, out double tongTien)
        {
            thanhTien = donGia * soLuong;
            thueVAT = thanhTien * VAT;
            tongTien = thanhTien + thueVAT;

        }
        //hàm tăng lên 1
        static void Tang1(ref int soLuong)
        {
            soLuong += 1;
        }
        // in ra màn hình
        static void Main()
        {
            double donGia;
            int soLuong;

            NhapDonGia(out donGia, out soLuong);
            Tang1(ref soLuong);
            double thanhTien;
            double tongTien;
            double thueVAT;
            TinhTien(donGia, soLuong, out thanhTien, out thueVAT, out tongTien);
            int tongTienInt = (int)tongTien;
            Console.WriteLine("số lượng tăng lên 1 :" + soLuong);
            Console.WriteLine("thành tiền :" + thanhTien);
            Console.WriteLine("thuế VAT :" + thueVAT);
            Console.WriteLine("tổng tiền :" + tongTien);
            Console.WriteLine("tổng tiền ép kiểu :" + tongTienInt);
            Console.ReadLine();

        }


    }
}
