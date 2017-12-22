using BDChef.Domain;
using BDChef.Domain.Generic;
using BDChef.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BDChef.WebUI.Controllers.API
{
    public class CustomerController : ApiController
    {
        private ICustomerService CustomerService;
        public CustomerController(ICustomerService CustomerService)
        {
            this.CustomerService = CustomerService;
        }

        public IHttpActionResult Get()
        {
            Response res = new Response();
            res.resultList = CustomerService.GetCustomerss();
            return Ok(res);

        }
    }
}
