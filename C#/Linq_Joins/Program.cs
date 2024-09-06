namespace Linq_Joins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1,"Tom",Gender.Male,24,"10024"),
                new Customer(2,"Mathew",Gender.Male,25,"10030"),
                new Customer(3,"Mary",Gender.Female,20,"10045"),
                new Customer(4,"Jane",Gender.Female,20,"10045"),
            };

            List<Order> orders = new List<Order>()
            {
                new Order(100,"Mexico",1),
                new Order(101,"NYC",2),
                new Order(102,"Los Vegas",3),
                new Order()
                {
                    OrderId = 103,
                    Address = "Nevada",
                    OrderDate = DateTime.Now,
                    
                }
            };
            Console.WriteLine("Customers");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("Orders");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }

            //using Lamda
            Console.WriteLine("----------------Inner Join-------------------");
            var innerJoin = orders.Join(customers, o => o.CustomerId,c=>c.Id,
                         (order, customer) => new
                         {
                             order.OrderId,
                             CustomerName = customer.name,
                         }).ToList();
            foreach (var order in innerJoin)
            {
                Console.WriteLine($"Order Id: {order.OrderId}; Customer Name: {order.CustomerName}");
            }
            Console.WriteLine("----------------Left Join-------------------");
            var leftJoin = orders.GroupJoin(customers, order => order.CustomerId, customer => customer.Id,
                          (order, customer) => new { order, customer }).SelectMany(x => x.customer.DefaultIfEmpty(), (order, customer) => new
                          {
                              OrderId = order.order.OrderId,
                              CustomerName = customer != null ? customer.name : "No Customer"
                          });
            foreach (var order in leftJoin)
            {
                Console.WriteLine($"Order Id: {order.OrderId}; Customer Name: {order.CustomerName}");
            }

            Console.WriteLine("----------------Right Join-------------------");
            var rightJoin = customers.GroupJoin(orders, customer => customer.Id, order => order.CustomerId,
                            (customer, order) => new { customer, order }).SelectMany(x => x.order.DefaultIfEmpty(), (c, o) => new
                            {
                                OrderId = o != null ? o.OrderId : -1,
                                CustomerName = c.customer.name,
                            });
            foreach (var order in rightJoin)
            {
                Console.WriteLine($"Order Id: {order.OrderId}; Customer Name: {order.CustomerName}");
            }

            // using SQL Like Syntax
            Console.WriteLine("--------------SQL Like Syntax-------------");
            Console.WriteLine("---------Inner Join-------");
            var sresult = from o in orders
                          join c in customers on o.CustomerId equals c.Id
                          select new {
                              o.OrderId,
                              CustomerName = c.name 
                          };
            foreach (var order in sresult)
            {
                Console.WriteLine($"Order Id: {order.OrderId}; Customer Name: {order.CustomerName}");
            }

            Console.WriteLine("----------------Left Join-------------------");
            var sqlLeftJoin = from o in orders
                           join c in customers on o.CustomerId equals c.Id into OrdersGroup
                           from og in OrdersGroup.DefaultIfEmpty()
                           select new
                           {
                               o.OrderId,
                               CustomerName = og != null ? og.name : "No Customer"
                           };
            foreach (var order in sqlLeftJoin)
            {
                Console.WriteLine($"Order Id: {order.OrderId}; Customer Name: {order.CustomerName}");
            }
            Console.WriteLine("----------------Right Join-------------------");
            var sqlRightJoin = from c in customers
                               join o in orders on c.Id equals o.CustomerId into OrdersGroup
                               from og in OrdersGroup.DefaultIfEmpty()
                               select new
                                {
                                   OrderId = og != null ? og.OrderId : -1,
                                   CustomerName = c.name,
                               };
            foreach (var order in sqlRightJoin)
            {
                Console.WriteLine($"Order Id: {order.OrderId}; Customer Name: {order.CustomerName}");
            }
        }
    }
}
