using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public delegate void DepositDelegate(User owner, User depositor, int amount);
    public class Account
    {
        public int TotalMoney { get; private set; }
        public Account(int totalMoney)
        {
            TotalMoney = totalMoney;
        }
        public void Deposit(int sum, User depositor, User user)
        {
            TotalMoney += sum;
            OnDepositEvent(user, depositor, sum);
        }
        public void Charge(int sum)
        {
            TotalMoney -= sum;
        }
        public event DepositDelegate DepositEvent;
        public void OnDepositEvent(User owner, User depositor, int amount)
        {
            if (DepositEvent != null)
            {
                DepositEvent(owner, depositor, amount);
            }
        }
    }
}
