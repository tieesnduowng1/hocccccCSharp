using System.Runtime;
using System.Text;

namespace bai_21_ve_tam_giac_sao
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("mời nhập chiều cao h của tam giác sao.");
            int chieuCaoh=Convert.ToInt32(Console.ReadLine());
            for(int soDongSao=1;soDongSao<=chieuCaoh;soDongSao++)
            {
                for (int khoangCach = 1; khoangCach <= chieuCaoh - soDongSao; khoangCach++)
                {
                    Console.Write(" ");
                }
                for (int inSao = 1; inSao <= soDongSao * 2 - 1; inSao++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                    


            }    
        }
    }
}
