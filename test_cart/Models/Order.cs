using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string OrderDetailID { get; set; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}