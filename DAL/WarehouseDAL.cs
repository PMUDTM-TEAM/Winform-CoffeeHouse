using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public WarehouseDAL()
        {

        }

        // Hàm lấy các danh sách nhập hàng của sản phẩm
        public List<WarehouseWithProduct> getWarehouse(int[] Provar_Id)
        {
            var result = (from w in db.Warehouses
                          join pv in db.ProductVariants on w.Provar_id equals pv.Id
                          join p in db.Products on pv.Pro_Id equals p.Id
                          join s in db.Sizes on pv.Size_Id equals s.Id
                          where Provar_Id.Contains(w.Provar_id.Value) 
                          orderby w.Day_In descending                 
                          select new WarehouseWithProduct
                          {
                              Id = w.Id,
                              Provar_id = w.Provar_id,
                              Pro_Name = p.Name,        
                              Size_Name = s.Size1,      
                              Quantity = w.Quantity,
                              Day_In = w.Day_In
                          }).ToList();

            return result;
        }

        public bool insertWarehouse(int quantity, int pro_id, int size_id)
        {
            try
            {
                ProductVariant provarFromDb = db.ProductVariants.FirstOrDefault(pv => pv.Pro_Id == pro_id && pv.Size_Id == size_id);
               
                Warehouse ware = new Warehouse
                {
                    Provar_id = provarFromDb.Id,
                    Quantity = quantity,
                    Day_In=DateTime.Now

                }; 
                db.Warehouses.InsertOnSubmit(ware);


                db.SubmitChanges();


                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi khi thêm liên kết: {ex.Message}");

                return false;
            }
        }
    }
}
