namespace buoi_3_ham_va_pham_vi_truy_cap
{
    internal class Program
        // hàm 
        static void Display()
   
    {
        static void Main(string[] args)
        {
            //// hằng số là giá trị cứng không thay dổi trong lúc chạy
            //int x = 100;
            //string a = @"C:\Window\sytems";
            //Console.WriteLine( a);
            //Hằng số đúng nghĩa (const)
            //hàm
            //cú pháp
            //(phạm vi truy cập)kiểu trả về -tên hàm -danh sách tham số
            //xử lý logic code
            // hàm có trả về giá trị thì phải có từ khóa return kêt thúc khối lệnh code
            static double TinhDienTichHCN(double chieuDai, double chieuRong)
            {
                double dienTich = chieuDai * chieuRong;
                return dienTich;
            }
            double chieuDai = 5.10, chieuRong = 4.3;
           double dienTichHCN= TinhDienTichHCN(chieuDai, chieuRong);
            Console.WriteLine( dienTichHCN);

            //hàm không trả về giá trị cụ thể
            //(void)
            //tham số bắt buộc




        
        }
    }
}
