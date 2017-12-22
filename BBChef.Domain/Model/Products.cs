using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BDChef.Models
{
   
    [Table("Products")]
    public class Products : BaseEntity
    {
      [Key]
      public int Id { get; set; }
      public string Name { get; set; }
      public string Code { get; set; }
      public int MinimumStock { get; set; }
      public decimal OtherCost { get; set; }
      public decimal Discount { get; set; }
      public decimal UnitePrice { get; set; }
      public decimal Quantity { get; set; }
      public decimal OpeningQuantity { get; set; }
        public Nullable<int> UOMId { get; set; }
        public Nullable<int> ProductBrandId { get; set; }
        public Nullable<int> ProductCatagoriesId { get; set; }
        public Nullable<int> ProductColorId { get; set; }
        public Nullable<int> ProductSizeId { get; set; }
        public Nullable<int> ProductTypeId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public ICollection<UOM> UOM { get; set; }
        public ICollection<ProductBrand> ProductBrand { get; set; }
        public ICollection<ProductCategory> ProductCategory { get; set; }
        public ICollection<ProductSize> ProductSize { get; set; }
        public ICollection<ProductBrand> ProductType { get; set; }
        public ICollection<Supplier> Supplier { get; set; }

    }
}
