//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBChef.Domain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductAssignDetail
    {
        public int Id { get; set; }
        public Nullable<int> ProductAssignId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Slup { get; set; }
        public Nullable<decimal> UnitePrice { get; set; }
        public Nullable<decimal> Bonus { get; set; }
        public Nullable<decimal> Returns { get; set; }
        public Nullable<decimal> Replace { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Date { get; set; }
        public Nullable<decimal> SalesQuantity { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsArchive { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedFrom { get; set; }
        public string LastUpdateBy { get; set; }
        public string LastUpdateAt { get; set; }
        public string LastUpdateFrom { get; set; }
    }
}
