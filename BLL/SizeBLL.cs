
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class SizeBLL
    {
        private SizeDAL size = new SizeDAL();

        public List<Size> getSizes()
        {
            return size.getSizes();
        }
        public bool insertSize(Size sizes)
        {
            return size.insertSizes(sizes);
        }

        public bool deleteSize(int size_id)
        {
            return size.deleteSize(size_id);
        }

        public bool updateSize(int id, string sizes, decimal price)
        {
            return size.updateSize(id, sizes, price);
        }
    }
}
