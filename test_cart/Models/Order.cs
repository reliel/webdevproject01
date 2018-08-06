using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Order
    {
        public int TableID { get; set; }
        public int ID { get; set; }
        public int OrderDetailID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipmentStatus { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}