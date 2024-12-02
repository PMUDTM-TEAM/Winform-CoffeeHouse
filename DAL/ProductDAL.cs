using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public  class ProductDAL
    {
        QLCFDataContext db = new QLCFDataContext();
        public ProductDAL() { }

        public List<ProductWithCategory> getProductsAndCateName()
        {
            var products = from p in db.Products
                           join c in db.Categories
                           on p.Cate_Id equals c.Id
                           select new ProductWithCategory
                           {
                               Id = p.Id,
                               Name = p.Name,
                               Image = p.Image,
                               Type = p.Type,
                               CategoryName = c.Name
                           };

            return products.ToList();
        }

        public bool insertProduct(Product product)
        {
            try
            {
                
                db.Products.InsertOnSubmit(product);

               
                db.SubmitChanges();

                
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Lỗi khi thêm sản phẩm: {ex.Message}");

                return false;
            }
        }

        public bool deleteProduct(int pro_id)
        {
            try
            {
                Product productToDelete = db.Products.FirstOrDefault(p => p.Id == pro_id);

                if (productToDelete == null)
                {
                    Console.WriteLine("Không tìm thấy sản phẩm cần xóa.");
                    return false;
                }

                db.Products.DeleteOnSubmit(productToDelete);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi xóa sản phẩm: {ex.Message}");

                return false;
            }
        }

        public bool updateProduct(int id,string name, string slug,string type,int cate_id, string image)
        {
            try
            {
               
                Product productFromDb = db.Products.FirstOrDefault(p => p.Id == id);

                
                if (productFromDb == null)
                {
                    Console.WriteLine("Không tìm thấy sản phẩm với id " + id);
                    return false;
                }

               
                if (!string.IsNullOrEmpty(name))
                {
                    productFromDb.Name = name;
                }

                if (!string.IsNullOrEmpty(slug))
                {
                    productFromDb.Slug = slug;
                }

                if (cate_id > 0) 
                {
                    productFromDb.Cate_Id = cate_id;
                }

                if (!string.IsNullOrEmpty(image))
                {
                    productFromDb.Image = image;
                }

                if (!string.IsNullOrEmpty(type))
                {
                    productFromDb.Type = type;
                }

                db.SubmitChanges();

                Console.WriteLine("Cập nhật sản phẩm thành công.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật sản phẩm: {ex.Message}");
                return false;
            }
        }

        public List<Product> getProductsByCateId(int cate_id)
        {
            return db.Products.Where(p=>p.Cate_Id == cate_id).ToList();
        }
    }
}
