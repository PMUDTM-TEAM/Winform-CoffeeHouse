using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class ToppingDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public ToppingDAL()
        {

        }

        public List<Topping> getToppings()
        {
            return db.Toppings.ToList();
        }

        public bool insertToppinh(Topping topping)
        {
            try
            {

                db.Toppings.InsertOnSubmit(topping);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi thêm topping: {ex.Message}");

                return false;
            }
        }

        public bool deleteTopping(int topping_id)
        {
            try
            {
                Topping ToppingToDelete = db.Toppings.FirstOrDefault(p => p.Id == topping_id);

                if (ToppingToDelete == null)
                {
                    Console.WriteLine("Không tìm thấy topping cần xóa.");
                    return false;
                }

                db.Toppings.DeleteOnSubmit(ToppingToDelete);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi xóa topping: {ex.Message}");

                return false;
            }
        }

        public bool updateTopping(int id, string name, decimal price)
        {
            try
            {

                Topping toppingFromDb = db.Toppings.FirstOrDefault(p => p.Id == id);


                if (toppingFromDb == null)
                {
                    Console.WriteLine("Không tìm thấy topping với id " + id);
                    return false;
                }


                if (!string.IsNullOrEmpty(name))
                {
                    toppingFromDb.Name = name;
                }

                if (price>0)
                {
                    toppingFromDb.Price = price;
                }



                db.SubmitChanges();

                Console.WriteLine("Cập nhật topping thành công.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật topping: {ex.Message}");
                return false;
            }
        }
    }
}
