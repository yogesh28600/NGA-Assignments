using System.Security.Cryptography.X509Certificates;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Yogesh","N",23,Gender.Male,30000);
            Person p2 = new Person("Kiran", "G", 24, Gender.Male, 20000);
            Person p3 = new Person("Mohan", "M", 32, Gender.Male, 35000);
            Person p4 = new Person("Prasanth", "B", 25, Gender.Male, 25000);
            Person p5 = new Person("Barath", "B", 35, Gender.Male, 20000);
            Person p6 = new Person("Avinash", "P", 26, Gender.Male, 15000);
            Person p7 = new Person("Ramya", "P", 27, Gender.Female, 14000);
            Person p8 = new Person("Bhagya", "P", 28, Gender.Female, 10000);

            var persons = new List<Person>();
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p8);
            persons.Add(p4);
            persons.Add(p7);
            persons.Add(p6);
            persons.Add(p3);
            persons.Add(p5);
            Console.WriteLine("List of persons");
            foreach(var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 1: a");
            var result = persons.Where(x => x.age > 30).Select(x => new {
                            fullname = x.first_name + " " +x.last_name
                         }).ToList();
            foreach (var person in result)
            {
                Console.WriteLine(person.fullname);
            }
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Task 1: b");
            var result1 = persons.OrderBy(x => x.last_name).ThenBy(x => x.first_name).ToList();
            foreach (var person in result1)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 2: a");
            var result2 = persons.Select(x=>x.age).Average();
            Console.WriteLine($"Average age of persons: {result2}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Task 2: b");
            var oldest= persons.OrderByDescending(x => x.age).Select(x => x.first_name).FirstOrDefault();
            var youngest = persons.OrderBy(x=>x.age).Select(x => x.first_name).FirstOrDefault();
            Console.WriteLine($"Oldest person in the list: {oldest}");
            Console.WriteLine($"Youngest person in the list: {youngest}");
            Console.WriteLine("-----------------------------------");
            //Other ways to solve task 2:b
            int min = persons.Min(x => x.age);
            int max = persons.Max(x => x.age);
            var result3 = persons.Where(x=>x.age == min || x.age == max).OrderBy(x=>x.age).Select(x=>x.first_name).ToList();
            Console.WriteLine($"Youngest person in the list: {result3[0]}");
            Console.WriteLine($"Oldest person in the list: {result3[1]}");
            //GroupBy
            var result4 = persons.GroupBy(x=>x.gender).ToList();
            foreach(var gender in result4)
            {
                Console.WriteLine("Persons with gender: "+gender.Key);
                foreach(var per in gender.Select(x=>x.first_name))
                {
                    Console.WriteLine(per);
                }

            }
        }
    }
}
