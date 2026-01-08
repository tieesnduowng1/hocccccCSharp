using System.Text;

namespace buoi4_bai20_dao_nguoc_1_so_nhap_vao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("mời nhập vào 1 số nguyên dương.");
            int number=Convert.ToInt32(Console.ReadLine());
            while (number <= 0) 
            {
                Console.WriteLine("bạn đã nhập sai nhập lại.");
                number = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write($"số đảo ngược của {number} là : ");
            while (number >= 1)
            {
                int  newnumber = number % 10;
                Console.Write(newnumber);
                number /= 10;
            }    
                
        }
    }
}
