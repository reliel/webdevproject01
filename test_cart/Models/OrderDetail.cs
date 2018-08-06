using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class OrderDetail
    {
        public int TableID { get; set; }
        public int OrderDetailID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string CheckedOut { get; set; }
        
        
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}