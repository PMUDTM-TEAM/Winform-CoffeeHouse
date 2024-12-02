using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {

        QLCFDataContext db = new QLCFDataContext();

        public CategoryDAL()
        {

        }

        public List<Category> getCategories()
        {
            return db.Categories.ToList();
        }

        public List<CategoryWithProducts> getCateWithProducts()
        {
            try
            {
                // Sử dụng LINQ để lấy dữ liệu từ bảng Category và Product
                var result = (from c in db.Categories
                              join p in db.Products on c.Id equals p.Cate_Id into productsGroup
                              select new CategoryWithProducts
                              {
                                  Id = c.Id,
                                  Name = c.Name,
                                  CountProducts = productsGroup.Count()
                              }).ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách CategoryWithProducts: {ex.Message}");
                return new List<CategoryWithProducts>();
            }
        }

        public bool insertCategory(Category cate)
        {
            try
            {

                db.Categories.InsertOnSubmit(cate);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi thêm sản phẩm: {ex.Message}");

                return false;
            }
        }

        public bool deleteCategory(int cate_id)
        {
            try
            {
                Category catetToDelete = db.Categories.FirstOrDefault(p => p.Id == cate_id);

                if (catetToDelete == null)
                {
                    Console.WriteLine("Không tìm thấy danh mục cần xóa.");
                    return false;
                }

                db.Categories.DeleteOnSubmit(catetToDelete);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi xóa danh mục: {ex.Message}");

                return false;
            }
        }

        public bool updateCategory(int id, string name, string slug)
        {
            try
            {

                Category catetFromDb = db.Categories.FirstOrDefault(p => p.Id == id);


                if (catetFromDb == null)
                {
                    Console.WriteLine("Không tìm thấy danh mục với id " + id);
                    return false;
                }


                if (!string.IsNullOrEmpty(name))
                {
                    catetFromDb.Name = name;
                }

                if (!string.IsNullOrEmpty(slug))
                {
                    catetFromDb.Slug = slug;
                }

               

                db.SubmitChanges();

                Console.WriteLine("Cập nhật danh mục thành công.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật danh mục: {ex.Message}");
                return false;
            }
        }
    }
}
