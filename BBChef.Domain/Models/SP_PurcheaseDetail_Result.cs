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
    
    public partial class SP_PurcheaseDetail_Result
    {
        public int Id { get; set; }
        public string InvoiecNo { get; set; }
        public string Date { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierMobile { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierPresentAddress { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeMobile { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePresentAddress { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> ProductDiscount { get; set; }
        public Nullable<decimal> ProductQuantity { get; set; }
        public Nullable<decimal> ProdutUnitePrice { get; set; }
        public Nullable<decimal> SubAmount { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string UOMName { get; set; }
        public string ProductSize { get; set; }
    }
}