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
    
    public partial class productdetail_Result
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> MinimumStock { get; set; }
        public Nullable<decimal> OpeningQuantity { get; set; }
        public Nullable<decimal> UnitePrice { get; set; }
        public string BrandCode { get; set; }
        public string BrandName { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string SizeCode { get; set; }
        public string SizeName { get; set; }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public string UOMCode { get; set; }
        public string UOMName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
