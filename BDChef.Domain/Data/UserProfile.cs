using System;
namespace BDChef.Domain.Data
{
  public class UserProfile : BaseEntity
    {
        public object ID;

        public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Address { get; set; }      
      public virtual User User { get; set; }
    }
}
