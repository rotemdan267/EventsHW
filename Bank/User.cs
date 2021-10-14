using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class User
    {
        public string Username { get; set; }
        public string Password {  get; set; }
        public Account Account { get; set; }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Account = new Account(0);
            Account.DepositEvent += Message;
        }
        
        public void Message(User owner, User depositor, int amount)
        {
            Console.WriteLine($"You have now {Account.TotalMoney} NIS in your account");
        }
    }
    public static class UsersList
    {
        public static List<User> Users { get; set; } = new List<User>();

        public static void Add(User user)
        {
            Users.Add(user);
        }
        public static void Remove(User user)
        {
            Users.Remove(user);
        }
    }
}
