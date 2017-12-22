using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDChef.Models.Generic
{
   public class Request<T> where T:class
    {
        public string message { get; set; }
        public string StatuesCode { get; set; }
        public List<T> resultList { get; set; }
        public T result { get; set; }
        public string Token { get; set; }
    }
}
