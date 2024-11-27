using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SizeDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public SizeDAL()
        {

        }

        public List<Size> getSizes()
        {
            return db.Sizes.ToList();
        }

        public bool insertSizes(Size size)
        {
            try
            {

                db.Sizes.InsertOnSubmit(size);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi thêm size: {ex.Message}");

                return false;
            }
        }

        public bool deleteSize(int size_id)
        {
            try
            {
                Size sizeToDelete = db.Sizes.FirstOrDefault(p => p.Id == size_id);

                if (sizeToDelete == null)
                {
                    Console.WriteLine("Không tìm thấy size cần xóa.");
                    return false;
                }

                db.Sizes.DeleteOnSubmit(sizeToDelete);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi xóa size: {ex.Message}");

                return false;
            }
        }

        public bool updateSize(int id, string size, decimal price)
        {
            try
            {

                Size sizeFromDb = db.Sizes.FirstOrDefault(p => p.Id == id);


                if (sizeFromDb == null)
                {
                    Console.WriteLine("Không tìm thấy size với id " + id);
                    return false;
                }


                if (!string.IsNullOrEmpty(size))
                {
                    sizeFromDb.Size1 = size;
                }

                if (price > 0)
                {
                    sizeFromDb.Price = price;
                }



                db.SubmitChanges();

                Console.WriteLine("Cập nhật size thành công.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật size: {ex.Message}");
                return false;
            }
        }
    }
}
