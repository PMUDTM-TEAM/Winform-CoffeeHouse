using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LoginBLL
    {
        private LoginDAL loginDAL = new LoginDAL();

        public bool Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            return loginDAL.CheckLogin(email, password);
        }
    }
}
