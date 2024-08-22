using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Stack
    {
        static Employee[] employees = new Employee[20];
        static int top = -1;
        static int length = 0;

        public void Push(Employee emp)
        {

            if (top >= employees.Length)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            employees[++top] = emp;
            length++;
            Console.WriteLine(emp.name + " is pushed to stack");
        }
        public Employee Pop()
        {
            length--;
            return employees[top--];
        }
        public Employee Peek()
        {
            return employees[top];
        }
        public bool isEmpty()
        {
            return length == 0;
        }
    }
}
