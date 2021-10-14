// See https://aka.ms/new-console-template for more information
using Bank;


User user = new User("abc", "123");
UsersList.Add(user);
user = new User("def", "456");
UsersList.Add(user);
user = new User("ghi", "789");
UsersList.Add(user);
user = new User("qaz", "741");
UsersList.Add(user);
user = new User("wsx", "852");
UsersList.Add(user);

BankUI.SetEvents();
BankSafetyDepositBox.SetEvents();

for (int i = 0; i < 5; i++)
{
    BankUI.TryLogin();
}