using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDChef.Domain.Generic
{
   public class Response
    {
        public string message { get; set; }
        public string StatuesCode { get; set; }
        public dynamic resultList { get; set; }
        
    }
}
