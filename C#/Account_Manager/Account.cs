namespace Account_Manager
{
    public class Account
    {
        public int account_id { get; set; }
        public double balance { get; set; }
        Object _lock = new Object();

        public Account(int id, double amount) 
        { 
            this.account_id = id;
            this.balance = amount;
        }

        public double deposit(double amount)
        {
            lock (_lock)
            {
                this.balance += amount;
                Console.WriteLine($"Balanace after depositing {amount} in {account_id} is {this.balance}");
                return balance;
            }
        }
        public double withdraw(double amount)
        {
            lock (_lock)
            {
                this.balance -= amount;
                Console.WriteLine($"Balanace after withdrawing {amount} from {account_id} is {this.balance}");
                return amount;
            }

        }
    }
}
