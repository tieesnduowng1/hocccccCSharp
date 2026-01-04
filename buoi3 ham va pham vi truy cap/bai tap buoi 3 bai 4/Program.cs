using System.Text;

namespace bai_tap_buoi_3_bai_4
{
    internal class Program
    {
        const double VAT = 0.1;
        static void GiaGoc(out double giaGoc)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("mời nhập giá gốc.");
            giaGoc = Convert.ToDouble(Console.ReadLine());
        }
        static double TinhTien(ref  double giaGoc)
        {
            
            double giaSauThue = giaGoc * VAT + giaGoc;

         
            int giaSauThueLamTron = (int)Math.Round(giaSauThue);
            giaGoc=giaSauThueLamTron;
            return giaSauThue;

        }
        static void Main()
        {
            double giaGoc;
            GiaGoc(out giaGoc);
            

           
            double giaSauThue = TinhTien(ref giaGoc);
            Console.WriteLine($"giá sau thuế chưa làm tròn là {giaSauThue} đồng.");
            Console.WriteLine($"giá sau thuế làm tròn là {giaGoc} đồng.");
        }
    }
}
