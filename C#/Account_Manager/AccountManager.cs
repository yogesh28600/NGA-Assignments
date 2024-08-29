namespace Account_Manager
{
    public class AccountManager
    {
        Account account1;
        Account account2;
        public AccountManager(Account account1, Account account2)
        {
            this.account1 = account1;
            this.account2 = account2;
        }

        public void transfer(Account fromAccount, Account toAccount,double amount)
        {
            Console.WriteLine($"{amount} is transffering from {fromAccount.account_id} to {toAccount.account_id}");
            Thread.Sleep(1000);  
            toAccount.deposit(fromAccount.withdraw(amount));
            Console.WriteLine($"{amount} is successfully transffered from {fromAccount.account_id} to {toAccount.account_id}");
        }
    }
}
