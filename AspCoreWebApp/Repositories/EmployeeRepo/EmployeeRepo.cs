using AspCoreWebApp.Models;
using System.Data.SqlClient;

namespace AspCoreWebApp.Repositories.EmployeeRepo
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private string connectionString = "data source=DESKTOP-TIC5DM4;initial catalog=Employees;integrated security=true";


        public bool AddEmployee(EmployeeModel emp)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string cmd = "insert into Employees values(@fname,@mname,@lname,@email,@pnumber,@age,@address,@country,@salary,@dob)";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@fname", emp.firstName);
                sqlCommand.Parameters.AddWithValue("@mname", emp.middleName);
                sqlCommand.Parameters.AddWithValue("@lname", emp.lastName);
                sqlCommand.Parameters.AddWithValue("@email", emp.email);
                sqlCommand.Parameters.AddWithValue("@pnumber", emp.phoneNumber);
                sqlCommand.Parameters.AddWithValue("@age", emp.age);
                sqlCommand.Parameters.AddWithValue("@address", emp.address);
                sqlCommand.Parameters.AddWithValue("@country", emp.country);
                sqlCommand.Parameters.AddWithValue("@dob", emp.dob);
                sqlCommand.Parameters.AddWithValue("@salary", emp.salary);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                if(result == 0)
                {
                    return false;
                }
                return true;

            }
        }

        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> Employees = new List<EmployeeModel>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string cmd = "select * from Employees order by id DESC";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeModel emp = new EmployeeModel()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        firstName = reader["firstName"].ToString(),
                        middleName = reader["middleName"].ToString(),
                        lastName = reader["lastName"].ToString(),
                        age = Convert.ToInt32(reader["age"]),
                        email = reader["email"].ToString(),
                        phoneNumber = reader["phoneNumber"].ToString(),
                        address = reader["empAddress"].ToString(),
                        country = reader["country"].ToString(),
                        dob = Convert.ToDateTime(reader["dob"]),
                        salary = Convert.ToDouble(reader["salary"])
                    };
                    Employees.Add(emp);
                }

            }
            return Employees;
        }
        public EmployeeModel GetEmployee(int id)
        {
            EmployeeModel Employee = new EmployeeModel();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string cmd = "select * from Employees where id=@id";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Employee.Id = Convert.ToInt32(reader["id"]);
                    Employee.firstName = reader["firstName"].ToString();
                    Employee.middleName = reader["middleName"].ToString();
                    Employee.lastName = reader["lastName"].ToString();
                    Employee.age = Convert.ToInt32(reader["age"]);
                    Employee.email = reader["email"].ToString();
                    Employee.phoneNumber = reader["phoneNumber"].ToString();
                    Employee.address = reader["empAddress"].ToString();
                    Employee.country = reader["country"].ToString();
                    Employee.dob = Convert.ToDateTime(reader["dob"]);
                    Employee.salary = Convert.ToDouble(reader["salary"]);   
                }

            }
            return Employee;
        }
        public bool EditEmployee(EmployeeModel emp)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string cmd = "update Employees set firstName=@fname,middleName=@mname,lastName=@lname," +
                    "email=@email,phoneNumber=@pnumber,age=@age,empAddress=@address,country=@country,salary=@salary,dob=@dob where id=@id";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@fname", emp.firstName);
                sqlCommand.Parameters.AddWithValue("@mname", emp.middleName);
                sqlCommand.Parameters.AddWithValue("@lname", emp.lastName);
                sqlCommand.Parameters.AddWithValue("@email", emp.email);
                sqlCommand.Parameters.AddWithValue("@pnumber", emp.phoneNumber);
                sqlCommand.Parameters.AddWithValue("@age", emp.age);
                sqlCommand.Parameters.AddWithValue("@address", emp.address);
                sqlCommand.Parameters.AddWithValue("@country", emp.country);
                sqlCommand.Parameters.AddWithValue("@dob", emp.dob);
                sqlCommand.Parameters.AddWithValue("@salary", emp.salary);
                sqlCommand.Parameters.AddWithValue("@id", emp.Id);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    return false;
                }
                return true;

            }
        }
        public bool DeleteEmployee(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string cmd = "Delete from Employees where id=@id";
                SqlCommand sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlConnection.Open();
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 0)
                {
                    return false;
                }
                return true;
            }
        }

    }
}
