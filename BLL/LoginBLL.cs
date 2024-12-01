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
        public static string LoggedInUserName { get; set; }
        public bool Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            if (loginDAL.CheckLogin(email, password))
            {
                var account = loginDAL.GetAccountByEmail(email);
                if (account != null)
                {
                    LoggedInUserName = account.Name;
                }
                return true;
            }

            return false;
        }

    }
}
