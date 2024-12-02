using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ProductVariantBLL
    {
        private ProductVariantDAL provar=new ProductVariantDAL();

        public List<ProductVariantWithSize> getVariants(int Pro_Id)
        {
            return provar.getVariants(Pro_Id);
        }

        public bool insertProductVariant(ProductVariant pro)
        {
            return provar.insertProductVariant(pro);
        }

        public bool deleteProductVarian(int id)
        {
            return provar.deleteProductVarian(id);
        }

        public bool checkProductVariant(int pro_id, int size_id)
        {
            return provar.checkProductVariant(pro_id, size_id);
        }

        public bool updateProductVariant(int id, int quantity, decimal price)
        {
            return provar.updateProductVariant(id, quantity, price);
        }
    }
}
