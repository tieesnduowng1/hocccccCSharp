using System.Text;

namespace buoi4_bai_23_so_doi_xung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("mời nhập một số nguyên .");
            int number  = Convert.ToInt32(Console.ReadLine());
            int soDaoNguoc = 0;
            int soBanDau = number;
            while (number > 0)
            {
                int laySoDu = number % 10;
                 soDaoNguoc = (soDaoNguoc * 10) + laySoDu;
                number /= 10;
            }
            if (soDaoNguoc == soBanDau)
                Console.WriteLine($"số {soBanDau} là số đối lập .");
            else
                Console.WriteLine($"số {soBanDau} không phải là số đối lập .");
        }
    }
}
