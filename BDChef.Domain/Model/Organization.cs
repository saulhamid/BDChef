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

    public partial class Organization: BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
      
        public string Mobile { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string PABX { get; set; }
        public string Email { get; set; }
        public string FAX { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> DivisionId { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public ICollection<Country> Country { get; set; }
        public ICollection<Division> Division { get; set; }
        public ICollection<EnumDistric> District { get; set; }

    }
}
