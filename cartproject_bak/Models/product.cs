//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cartproject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int id { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public string product_title { get; set; }
        public string product_spec { get; set; }
        public Nullable<decimal> product_price { get; set; }
        public string product_description { get; set; }
        public string product_thumb { get; set; }
        public string product_image { get; set; }
    }
}
