using System.Text;

namespace buoi_4_bai6_tinh_tong_cac_chu__so_cu_1_so
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("mời nhập 1 số nguyên dương.");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number <= 0)
            {
                Console.WriteLine("bạn đã nhập sai số mời nhập lại .");
                number= Convert.ToInt32(Console.ReadLine());
            }
            int soNhapVaoBanDau=number;
            while (number >= 1)
                {
                    sum += number % 10;
                    number /= 10;
                }
                Console.WriteLine($"tổng các chữ số của số {soNhapVaoBanDau} = {sum}. ");
            Console.ReadLine();                        
            }                  
    }
}
