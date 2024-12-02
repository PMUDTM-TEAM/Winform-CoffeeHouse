using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class CategoryBLL
    {
        private CategoryDAL cate=new CategoryDAL();

        public List<Category> getCategories()
        {
            return cate.getCategories();    
        }

        public List<CategoryWithProducts> getCateWithProducts()
        {
            return cate.getCateWithProducts();
        }

        public bool insertCategory(Category category)
        {
            return cate.insertCategory(category);
        }

        public bool deleteCategory(int cate_id)
        {
            return cate.deleteCategory(cate_id);
        }

        public bool updateCategory(int id, string name, string slug)
        {
            return cate.updateCategory(id, name, slug);
        }
    }
}
