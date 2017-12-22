using BDChef.Data;
using BDChef.Domain;
using BDChef.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDChef.Service.Implementation
{
  public  class CustomerService: ICustomerService
    {
        private IRepository<Customers> CustomersRepository;
        public CustomerService(IRepository<Customers> CustomersRepository)
        {
            this.CustomersRepository = CustomersRepository;
        }
        public IQueryable<Customers> GetCustomerss()
        {
            try
            {
                return CustomersRepository.Table;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Customers GetCustomers(long id)
        {
            try
            {
                return CustomersRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }
        }
        public void InsertCustomers(Customers Customers)
        {
            CustomersRepository.Insert(Customers);
        }

        public void UpdateCustomers(Customers Customers)
        {
            CustomersRepository.Update(Customers);
        }

        public void DeleteCustomers(Customers Customers)
        {
            //CustomersProfileRepository.Delete(Customers.CustomersProfile);
            CustomersRepository.Delete(Customers);
        }
    }
}
