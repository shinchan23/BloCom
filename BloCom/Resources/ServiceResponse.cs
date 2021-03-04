using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloCom.Resources
{
    public class ServiceResponse<T>
    {
        public T GetT { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = String.Empty;
    }
}
