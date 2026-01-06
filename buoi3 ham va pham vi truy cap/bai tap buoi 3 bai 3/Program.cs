using System.Text;

namespace bai_tap_buoi_3_bai_3
{
    internal class Program
    {
        const int MIN_PER_HOUR= 60;
        const int SALARY_PER_HOUR = 45000;
        static void SoPhutLamViec(out int soPhutLamViec)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("mời nhập số phút làm việc.");
            soPhutLamViec=Convert.ToInt32(Console.ReadLine());
            
        }
        static double TinhTienLuong(ref  int soPhutLamViec)
        {
            double soGioLamViec =(double)soPhutLamViec / 60;
            double tienLuong = soGioLamViec * SALARY_PER_HOUR;
            int soGioLamViecLamTron = (int)Math.Round(soGioLamViec);
            soPhutLamViec = soGioLamViecLamTron;

            return tienLuong;
        }
        static void Main()
        {
            int soPhutLamViec;
            SoPhutLamViec(out  soPhutLamViec);
            
            double tienLuong = TinhTienLuong(ref  soPhutLamViec);
            Console.WriteLine($"số giờ làm việc làm tròn là {soPhutLamViec} giờ.");
            Console.WriteLine($"tổng tiền lương là {tienLuong} đồng.");

            

        }
    }
}
