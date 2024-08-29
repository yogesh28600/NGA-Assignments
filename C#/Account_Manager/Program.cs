namespace Account_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1, 1000);
            Account account2 = new Account(2, 1000);
            Console.WriteLine($"Balance in account {account1.account_id} is: {account1.balance}");
            Console.WriteLine($"Balance in account {account2.account_id} is: {account2.balance}");
            AccountManager manager = new AccountManager(account1, account2);
            Thread thread1 = new Thread(() => { manager.transfer(account1, account2, 500); });
            Thread thread2 = new Thread(() => { manager.transfer(account2 , account1, 250); });
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            Console.WriteLine($"Balance in account {account1.account_id} is: {account1.balance}");
            Console.WriteLine($"Balance in account {account2.account_id} is: {account2.balance}");
        }
    }
}
