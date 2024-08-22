using System.Xml.Serialization;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Yogesh", Gender.Male, "987654321");
            Employee emp2 = new Employee("Kiran", Gender.Male, "987654322");
            Employee emp3 = new Employee("Avinash", Gender.Male, "987654323");
            Employee emp4 = new Employee("Mohan", Gender.Male, "987654324");
            /*Stack stack = new Stack();
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(emp4);

            Console.WriteLine("Pop: " + stack.Pop().ToString());

           Console.WriteLine("Peek: " + stack.Peek().ToString());

            Console.WriteLine("isEmpty:" + stack.isEmpty());*/

            Queue queue = new Queue();

            queue.Enqueue(emp1);
            queue.Enqueue(emp2);
            queue.Enqueue(emp3);
            queue.Enqueue(emp4);

            Console.WriteLine("Peek: " + queue.Peek().ToString());

            Console.WriteLine("isEmpty:" + queue.isEmplty());

            Console.WriteLine("Dequeue: " + queue.Dequeue().ToString());
            Console.WriteLine("Dequeue: " + queue.Dequeue().ToString());
            Console.WriteLine("Dequeue: " + queue.Dequeue().ToString());
            Console.WriteLine("Dequeue: " + queue.Dequeue().ToString());

            Console.WriteLine("isEmpty:" + queue.isEmplty());

        }
    }
}
