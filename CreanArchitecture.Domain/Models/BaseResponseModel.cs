using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreanArchitecture.Domain.Models
{
    public class BaseResponseModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }       
        public bool  Success { get; set; }
        public dynamic Data { get; set; }
    }
}
