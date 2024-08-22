using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Queue
    {
        static Employee[] employees = new Employee[20];
        static int head = 0; 
        static int tail = 0;
        static int length = 0;
        
        public void Enqueue(Employee emp)
        {
            if (tail >= employees.Length)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            employees[tail++] = emp;
            length++;
            Console.WriteLine(emp.name + " is Added to Queue");
        }
        public Employee Dequeue()
        {
            if(head<0)
            {
                Console.WriteLine("queue is empty");
                return null;
            }
            length--;
            return employees[head++];
        }
        public Employee Peek()
        {
            return employees[head];
        }
        public bool isEmplty()
        {
            return length == 0;
        }
    }
}
