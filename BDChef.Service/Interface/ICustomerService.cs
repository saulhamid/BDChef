using BDChef.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDChef.Service.Interface
{
   public interface ICustomerService
    {
        IQueryable<Customers> GetCustomerss();
        Customers GetCustomers(long id);
        void InsertCustomers(Customers Customers);
        void UpdateCustomers(Customers Customers);
        void DeleteCustomers(Customers Customers);
    }
}
