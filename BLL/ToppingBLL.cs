using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ToppingBLL
    {
        private ToppingDAL top=new ToppingDAL();

        public List<Topping> getTopping()
        {
            return top.getToppings();
        }
        public bool insertTopping(Topping topping)
        {
            return top.insertToppinh(topping);
        }

        public bool deleteTopping(int topping_id)
        {
            return top.deleteTopping(topping_id);
        }

        public bool updateTopping(int id, string name, decimal price)
        {
            return top.updateTopping(id, name, price);
        }
    }
}
