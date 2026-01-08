namespace buoi4_bai_22_tinh_giai_thua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi nhap 1 so nguyen duong");
            int number=Convert.ToInt32(Console.ReadLine());
            decimal giaiThua = 1;
            while (number <= 0)
                Console.WriteLine("moi nhap lai");
            for (int i = 1; i <= number; i++)
            {
                giaiThua *= i;
                
            }
            Console.WriteLine($"giai thua cua {number}= " + giaiThua);


        }
    }
}
