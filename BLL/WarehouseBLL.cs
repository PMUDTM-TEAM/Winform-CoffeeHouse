using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class WarehouseBLL
    {
        private WarehouseDAL ware=new WarehouseDAL();

        public List<WarehouseWithProduct> getWarehouse(int[] Provar_Id)
        {
            return ware.getWarehouse(Provar_Id);
        }

        public bool insertWarehouse(int quantity, int pro_id, int size_id)
        {
            return ware.insertWarehouse(quantity, pro_id, size_id);
        }
    }
}
