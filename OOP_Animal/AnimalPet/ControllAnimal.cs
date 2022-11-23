using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPet
{
   
    internal class ControllAnimal
    {
        private List<Animal> ListDongVat = null;

        public ControllAnimal()
        {
            ListDongVat = new List<Animal>();
        }
        // ham tao ID tang dan cho DongVat
        private int GenerateID()
        {
            int max = 1;
            if (ListDongVat != null && ListDongVat.Count > 0)
            {
                max = ListDongVat[0].ID;
                foreach (Animal Dv in ListDongVat)
                {
                    if (max < Dv.ID)
                    {
                        max = Dv.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int SoLuongDongVat()
        {
            int Count = 0;
            if (ListDongVat != null)
            {
                Count = ListDongVat.Count;
            }
            return Count;
        }
        public void NhapDongVat()
        {
            // Khởi tạo một động vật mới
            Animal Dv = new Animal();
            Dv.ID = GenerateID();
            Console.Write("Nhập tên động vật: ");
            Dv.TenDongVat = Convert.ToString(Console.ReadLine());

            Console.Write("nhap màu nong: ");
            Dv.MauDongVat = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap so can nang: ");
            Dv.CanNang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap chieu cao: ");
            Dv.ChieuCao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap tieng keu: ");
            Dv.TiengKeu  = Convert.ToString(Console.ReadLine());

           


            ListDongVat.Add(Dv);

        }
            public void UpdateDongVat(int id)
            {
                // Tìm kiếm sinh viên trong danh sách ListDongVat
                Animal Dv = FindByID(id);
                // Nếu sinh viên tồn tại thì cập nhập thông tin Animal
                if (Dv != null)
                {
                    Console.Write("Nhap tên động vật: ");
                    string TenDongVat = Convert.ToString(Console.ReadLine());
                    // Nếu không nhập gì thì không cập nhật tên
                    if (TenDongVat != null && TenDongVat.Length > 0)
                    {
                      Dv.TenDongVat = TenDongVat;
                    }

                    Console.Write("nhập màu nông động vật : ");
                    // Nếu không nhập gì thì không cập nhật màu nông
                    string MauDongVat = Convert.ToString(Console.ReadLine());
                    if (MauDongVat != null && MauDongVat.Length > 0)
                    {
                        Dv.MauDongVat = MauDongVat;
                    }

                Console.Write("nhập chiều cao động vật: ");
                int height = Convert.ToInt32(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật chieu cao
                if (height != null && height > 0)
                {
                    Dv.ChieuCao = Convert.ToInt32(height);
                }

                Console.Write("Nhap can nang");
                int weight = Convert.ToInt32(Console.ReadLine());
                // Nếu không nhập gì thì không cập nhật số cân năng
                if (weight != null && weight > 0)
                {
                    Dv.CanNang = Convert.ToInt32(weight);
                }

                Console.Write("Nhap tieng keu: ");
                    string tiengKeu = Convert.ToString(Console.ReadLine());
                    // Nếu không nhập gì thì không cập nhật điểm lý
                    if (tiengKeu != null && tiengKeu.Length > 0)
                    {
                        Dv.TiengKeu = Convert.ToString(tiengKeu);
                    }

                   

                    
                }
                else
                {
                    Console.WriteLine("Dong vat co ID = {0} khong ton tai.", id);
                }
            }

        public void SortByID() //-------hàm sắp xếp  động vật thứ tự  tăng dân
        {
            ListDongVat.Sort(delegate (Animal Dv1, Animal Dv2) {
                return Dv1.ID.CompareTo(Dv2.ID);
            });
        }
        public bool DeleteById(int id) //---- hàm xoá dộng vật theo id
        {
            bool IsDeleted = false;
            // tìm kiếm động vật theo ID
            Animal Dv = FindByID(id);
            if (Dv != null)
            {
                IsDeleted = ListDongVat.Remove(Dv);
            }
            return IsDeleted;
        }
        // hàm hiển thị danh sách dộng vật
        public void ShowDongVat(List<Animal> listDV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5}",
                  "ID", "Tên Động Vật", "Màu Lông", "Cân nặng", "Chiều cao", "Tiếng kêu");
            // hien thi danh sach dong vat
            if (listDV != null && listDV.Count > 0)
            {
                foreach (Animal Dv in listDV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5}",
                                      Dv.ID, Dv.TenDongVat, Dv.MauDongVat, Dv.CanNang, Dv.ChieuCao, Dv.TiengKeu);
                }
            }
            Console.WriteLine();
        }

        public Animal FindByID(int id)
        {
            Animal searchResult = null;
            if (ListDongVat != null && ListDongVat.Count > 0)
            {
                foreach (Animal Dv in ListDongVat)
                {
                    if (Dv.ID == id)
                    {
                        searchResult = Dv;
                    }
                }
            }
            return searchResult;
     
        }
        public List<Animal> getListDongVat()
        {
            return ListDongVat;
        }
    }

}
