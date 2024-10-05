namespace AspEFCore.Factory
{
    public class ContractualEmployee : IEmployeeManager
    {

        public double GetBonus()
        {
            return 1000;
        }

        public double GetPay()
        {
            return 8000;
        }
    }
}
