using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class BankSafetyDepositBox
    {
        private static int amount;

        public static int Amount
        {
            get { return amount; }
            set 
            {
                amount = 0;
                foreach (User user in UsersList.Users)
                {
                    amount += user.Account.TotalMoney;
                }
            }
        }
        public static void SetEvents()
        {
            foreach (User user in UsersList.Users)
            {
                user.Account.DepositEvent += Message;
            }
        }

        public static void Message(User owner, User depositor, int amount)
        {
            foreach (User user in UsersList.Users)
            {
                Amount += user.Account.TotalMoney;
            }
            Console.WriteLine($"The bank has now {Amount} NIS");
        }

    }
}
