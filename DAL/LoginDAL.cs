using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class LoginDAL
    {
        QLCFDataContext db = new QLCFDataContext();

        public LoginDAL()
        {
           
        }

        public bool CheckLogin(string email, string password)
        {
            return db.Accounts.Any(a => a.Email == email && a.Password == password && a.Role.Name == "Admin");
        }


    }
}
