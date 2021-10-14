using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public delegate void Log(User user, string message);
    public static class Login
    {
        public static void LoginAttempt(User user)
        {
            bool didEventHappen = false;
            foreach (User item in UsersList.Users)
            {
                if (user.Username == item.Username)
                {
                    if (user.Password == item.Password)
                    {
                        didEventHappen = true;
                        SuccessLoginEvent(item, "Success");
                        break;
                    }
                    else
                    {
                        didEventHappen = true;
                        UnsuccessfulLoginEvent(item, "Wrong password");
                        break;
                    }
                }
            }
            if (!didEventHappen)
            {
                UnsuccessfulLoginEvent(user, "Username does not exist");
            }
        }
        public static event Log SuccessLoginEvent;
        public static event Log UnsuccessfulLoginEvent;
    }
}
