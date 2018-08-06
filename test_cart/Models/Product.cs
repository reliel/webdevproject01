using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }
        public int ProductID { get; set; }
        public string ProductCatagory { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }
        
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}