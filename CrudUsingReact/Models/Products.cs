using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudUsingReact.Models
{
    public class Products
    {
        public long ProductId { get; set; }
        public string ProductUid { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public byte[] CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}