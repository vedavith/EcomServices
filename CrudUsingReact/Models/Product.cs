//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudUsingReact.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public long ProductId { get; set; }
        public string ProductUid { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public byte[] CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ProductCategory { get; set; }
    }
}
