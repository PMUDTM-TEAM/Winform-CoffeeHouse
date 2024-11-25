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
    }
}
