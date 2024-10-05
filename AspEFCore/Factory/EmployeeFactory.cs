namespace AspEFCore.Factory
{
    public class EmployeeFactory
    {
        public IEmployeeManager GetEmployee(int emp_type)
        {
            IEmployeeManager employeeManager = null;
            if(emp_type == 1)
            {
                employeeManager = new PermanentEmployee();
            }
            else if(emp_type == 2)
            {
                employeeManager = new ContractualEmployee();
            }
            return employeeManager;
        }
    }
}
