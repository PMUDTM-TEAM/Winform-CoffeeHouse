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
    }
}
