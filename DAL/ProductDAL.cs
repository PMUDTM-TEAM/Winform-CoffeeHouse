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
    }
}
