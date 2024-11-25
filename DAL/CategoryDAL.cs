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
    }
}
