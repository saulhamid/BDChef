//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDChef.Domain
{
   
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("ProductAssign")]
    public partial class ProductAssign: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string InvoiecNo { get; set; }
        public Nullable<decimal> TotalDiscount { get; set; }
        public Nullable<decimal> TotalSlup { get; set; }
        public Nullable<decimal> TotalQuantity { get; set; }
        public Nullable<decimal> TotalPaid { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public string Date { get; set; }
        public Nullable<decimal> OpeningQuantity { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ZoneOrAreaId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public ICollection<Products> Product { get; set; }
        public ICollection<Customers> Customer { get; set; }
        public ICollection<ZoneOrArea> ZoneOrArea { get; set; }
        public ICollection<Employee> Employee { get; set; }


    }
}
