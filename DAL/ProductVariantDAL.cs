using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ProductVariantDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public ProductVariantDAL()
        {

        }

        public List<ProductVariantWithSize> getVariants(int Pro_Id) 
        {
            var result = (from pv in db.ProductVariants
                          join p in db.Products on pv.Pro_Id equals p.Id
                          join s in db.Sizes on pv.Size_Id equals s.Id
                          where pv.Pro_Id == Pro_Id
                          select new ProductVariantWithSize
                          {
                              Id = pv.Id,
                              Pro_Id = pv.Pro_Id,
                              Pro_Name = p.Name,   // Lấy tên sản phẩm
                              Size_Id = pv.Size_Id,
                              Size_Name = s.Size1, // Thuộc tính "Size1" từ bảng Size
                              Quantity = pv.Quantity,
                              Price = pv.Price
                          }).ToList();

            return result;
        }


        public bool insertProductVariant(ProductVariant pro)
        {
            try
            {

                db.ProductVariants.InsertOnSubmit(pro);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi thêm liên kết: {ex.Message}");

                return false;
            }
        }

        public bool deleteProductVarian(int id)
        {
            try
            {
                ProductVariant productVariantToDelete = db.ProductVariants.FirstOrDefault(p => p.Id == id);

                if (productVariantToDelete == null)
                {
                    Console.WriteLine("Không tìm thấy liên kết cần xóa.");
                    return false;
                }

                db.ProductVariants.DeleteOnSubmit(productVariantToDelete);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi xóa liên kết: {ex.Message}");

                return false;
            }
        }

        public bool checkProductVariant(int pro_id,int size_id)
        {
            var exists = db.ProductVariants.Any(pv => pv.Pro_Id == pro_id && pv.Size_Id == size_id);
            return exists;
        }

        public bool updateProductVariant(int id, int quantity , decimal price)
        {
            try
            {

                ProductVariant provarFromDb = db.ProductVariants.FirstOrDefault(p => p.Id == id);


                if (provarFromDb == null)
                {
                    Console.WriteLine("Không tìm thấy liên kết với id " + id);
                    return false;
                }


                if (quantity>0)
                {
                    provarFromDb.Quantity = quantity;
                }

                if (price > 0)
                {
                    provarFromDb.Price = price;
                }



                db.SubmitChanges();

                Console.WriteLine("Cập nhật liên kết thành công.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật liên kết: {ex.Message}");
                return false;
            }
        }
    }
}
