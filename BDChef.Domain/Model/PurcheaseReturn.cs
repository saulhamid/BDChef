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

    public partial class PurcheaseReturn: BaseEntity
    {
        public int Id { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> PurchaseId { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TotalPaid { get; set; }
        public string InvoiceNo { get; set; }
        public string Date { get; set; }
  
    }
}
