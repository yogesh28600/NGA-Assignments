using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET
{
    internal class EmployeeCRUD
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
        public EmployeeCRUD()
        {
/*            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "create table Department (Id int Identity Primary key,Dep_Name nvarchar(20));create table Employee (Id int Identity Primary key,Emp_Name nvarchar(20),Gender nvarchar(10),Age int ,Salary float,DepId int Foreign key references Department);";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
            }*/
        }
        public void AddEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "insertEmployee";
                SqlCommand cmd = new SqlCommand(command,sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@gender",employee.gender);
                cmd.Parameters.AddWithValue("@age", employee.age);
                cmd.Parameters.AddWithValue("@salary", employee.salary);
                cmd.Parameters.AddWithValue("@depId", employee.depId);
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("----------------Employee Added Successfully-------------------");
                }
            }
        }
        public void DeleteEmployee(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "Delete from Employee where Id = @Id";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                cmd.Parameters.AddWithValue("@Id", id);
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("----------------Employee Deleted Successfully-------------------");
                }
            }
        }
        public void UpdateEmployee(int id, Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "update Employee set Emp_Name=@name,Gender=@gender,Age=@age,Salary=@salary,DepId=@depId where Id = @Id";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@gender", employee.gender);
                cmd.Parameters.AddWithValue("@age", employee.age);
                cmd.Parameters.AddWithValue("@salary", employee.salary);
                cmd.Parameters.AddWithValue("@depId", employee.depId);
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("----------------Employee Updated Successfully-------------------");
                }
            }
        }
        public void GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "Select * from Employee";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(new Employee()
                    {
                        Id = Convert.ToInt16(reader["Id"]),
                        name = reader["Emp_Name"].ToString(),
                        gender = reader["Gender"].ToString(),
                        age = Convert.ToInt32(reader["Age"]),
                        salary = Convert.ToDouble(reader["Salary"]),
                        depId = Convert.ToInt16(reader["DepId"])
                    });
                }
            }
            foreach( Employee employee in employees )
            {
                Console.WriteLine(employee);
            }
        }
        public Employee GetEmployee(int Id)
        {
            Employee emp = new Employee();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string command = "Select * from Employee where Id = @Id";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                cmd.Parameters.AddWithValue("@Id", Id);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp = new Employee()
                    {
                        Id = Convert.ToInt16(reader["Id"]),
                        name = reader["Emp_Name"].ToString(),
                        gender = reader["Gender"].ToString(),
                        age = Convert.ToInt32(reader["Age"]),
                        salary = Convert.ToDouble(reader["Salary"]),
                        depId = Convert.ToInt16(reader["DepId"])
                    };
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
            return emp;
        }
        public void AddDepartment(Department dep)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString ))
            {
                string command = "Insert into Department values (@dep_name)";
                SqlCommand cmd = new SqlCommand(command, sqlConnection);
                cmd.Parameters.AddWithValue("@dep_name", dep.name);
                sqlConnection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Department Added Successfully");
                }
            }
        }
    }
}
