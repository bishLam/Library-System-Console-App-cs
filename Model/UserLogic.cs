using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserLogic
    {
        public User UserLogin(string username, String password)
        {
            UserDAO userDAO = new UserDAO();
            User user = userDAO.UserLogin(username, password);

            return user;
        }
    }
}
