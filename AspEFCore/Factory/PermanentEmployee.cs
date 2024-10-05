using AspEFCore.Models;

namespace AspEFCore.Factory
{
    public class PermanentEmployee : IEmployeeManager
    {

        public double GetBonus()
        {
            return 2000;
        }

        public double GetPay()
        {
            return 10000;
        }
    }
}
