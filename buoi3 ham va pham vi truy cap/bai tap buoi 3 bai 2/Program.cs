using System.Text;
using System.Threading.Channels;

namespace bai_tap_buoi_3_bai_2
{
    internal class Program
    {
        const int WH_TO_KWH = 1000;
        const double PRICE_PER_KWH = 2500;
        static void DuLieuVao(out int soDienWH)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập vào số ddienje tiêu thụ wh.");
            soDienWH=Convert.ToInt32(Console.ReadLine());

        }
        static double TinhTienDien(ref int soDienKWHLamTron, int soDienWH)
        {
           
            
            soDienKWHLamTron=(int)Math.Round((double)soDienWH / WH_TO_KWH);
            double tienDien = soDienKWHLamTron * PRICE_PER_KWH;
            return tienDien;
        }
        static void Main()
        {
            int soDienWH;
            DuLieuVao(out  soDienWH);
            int soDienKWHLamTron=0;
            double tienDien= TinhTienDien(ref soDienKWHLamTron, soDienWH); 

           
            Console.WriteLine($"số điện tiêu dùng hết {soDienKWHLamTron} số.");
            Console.WriteLine($"số tiền điện là {tienDien} đồng.");

        }
    }
}
