using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UserController
    {
        public User UserLogin(string username, string password) {
            UserLogic userLogic = new UserLogic();
            User user = userLogic.UserLogin(username, password);
            return user;
        }
    }
}
