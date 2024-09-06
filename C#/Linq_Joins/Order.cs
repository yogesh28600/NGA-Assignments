using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Joins
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Address {  get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId {  get; set; }

        public Order()
        {
            
        }
        public Order(int OrderId, string Address, int CustomerId)
        {
            this.OrderId = OrderId;
            this.Address = Address;
            this.CustomerId = CustomerId;
            this.OrderDate = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Order Id: {OrderId};  Address: {Address}; Order date: {OrderDate}; Customer Id: {CustomerId}";
        }

    }
}
