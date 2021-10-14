using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class BankUI
    {
        public static void TryLogin()
        {
            Console.Write("Username= ");
            string username = Console.ReadLine();
            Console.Write("Password= ");
            string password = Console.ReadLine();

            Login.LoginAttempt(new User(username, password));
        }

        public static void SetEvents()
        {
            Login.SuccessLoginEvent += Outcome;
            Login.UnsuccessfulLoginEvent += Outcome;
            foreach (User user in UsersList.Users)
            {
                user.Account.DepositEvent += Message;
            }
        }

        public static void Outcome(User user, string message)
        {
            if (message == "Success")
            {
                Console.WriteLine($"Welcome {user.Username}, How much money would you like to deposit?");
                bool flag = false;
                int amount = 0;
                while (!flag)
                {
                    flag = int.TryParse(Console.ReadLine(), out amount);
                    if (!flag)
                        Console.WriteLine("Wrong input. try again");
                }
                user.Account.Deposit(amount, user, user);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
        public static void Message(User owner, User depositor, int amount)
        {
            Console.WriteLine($"Hello {owner.Username}. You received {amount} NIS. Depositor: {depositor.Username}");
        }
    }
}
