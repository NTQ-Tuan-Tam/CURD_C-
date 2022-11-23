using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalPet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            ControllAnimal quanlydongvat = new ControllAnimal();

            while (true)
            {
                Console.WriteLine("\n ứng dụng quản lý thú cưng");
                Console.WriteLine("\n---------------------Menu----------------");
                Console.WriteLine("\n-- 1. Thêm động vật                   ---");
                Console.WriteLine("\n-- 2. Cập nhật động vật                    ---");
                Console.WriteLine("\n-- 3. cập nhập động vật               ---");
                Console.WriteLine("\n-- 4. hiển thị danh sách động         ---");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n 1. thêm động vật");
                        quanlydongvat.NhapDongVat();
                        Console.WriteLine("thêm động vật thành công !!!");
                        break;
                    case 2:
                        Console.WriteLine("\n 2. cập nhật động vật");
                        if (quanlydongvat.SoLuongDongVat() > 0 )
                        {
                            int stt;
                            Console.WriteLine("cập nhật động vật");
                            Console.Write("\nNhap ID: ");
                            stt = Convert.ToInt32(Console.ReadLine());
                            quanlydongvat.UpdateDongVat(stt);
                        }
                        break;
                    case 3:
                        if (quanlydongvat.SoLuongDongVat() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Xoa Động Vật.");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (quanlydongvat.DeleteById(id))
                            {
                                Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;

                        
                    case 4:
                        if (quanlydongvat.SoLuongDongVat() > 0)
                        {
                            Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                            quanlydongvat.ShowDongVat(quanlydongvat.getListDongVat());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                       
                    default:
                        Console.WriteLine(" \n không có chức năng này. Xin hãy nhập lại !!!");
                        break;








                }



            }
                Console.ReadKey();

        }
    }
}
