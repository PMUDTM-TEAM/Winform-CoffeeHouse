using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ProductBLL
    {
        private ProductDAL pro=new ProductDAL();

        public List<ProductWithCategory> getProductsAndCateName()
        {
            return pro.getProductsAndCateName();
        }
        public bool insertProduct(Product product)
        {
            return pro.insertProduct(product);
        }

        public bool deleteProduct(int pro_id)
        {
            return pro.deleteProduct(pro_id);
        }

        public bool updateProduct(int id, string name, string slug,string type, int cate_id, string image)
        {
            return pro.updateProduct( id,  name,  slug, type, cate_id,  image);
        }
    }
}
