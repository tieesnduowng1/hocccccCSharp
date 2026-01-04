using System.Text;

namespace bai_tap_buoi_3_bai_3
{
    internal class Program
    {
        const int MIN_PER_HOUR= 60;
        const int SALARY_PER_HOUR = 4500;
        static void SoPhutLamViec(out int soPhutLamViec)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("mời nhập số phút làm việc.");
            soPhutLamViec=Convert.ToInt32(Console.ReadLine());
            
        }
        static double TinhTienLuong(ref double soGioLamViecLamTron, int soPhutLamViec)
        {
            soGioLamViecLamTron = (int)Math.Round((double)soPhutLamViec / 60);
            double tienLuong = soGioLamViecLamTron * SALARY_PER_HOUR;
            return tienLuong;
        }
        static void Main()
        {
            int soPhutLamViec;
            SoPhutLamViec(out  soPhutLamViec);
            double soGioLamViecLamTron = 0;
            double tienLuong = TinhTienLuong(ref soGioLamViecLamTron, soPhutLamViec);
            Console.WriteLine($"số giờ làm việc làm tròn là {soGioLamViecLamTron} giờ.");
            Console.WriteLine($"tổng tiền lương là {tienLuong} đồng.");

            

        }
    }
}
