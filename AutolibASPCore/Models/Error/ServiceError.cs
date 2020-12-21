using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutolibASPCore.Models.Error
{
    public class ServiceError: Exception
    {
        private string module;
        private string message;
        public ServiceError(string module = "", string message = "")
        {
            this.module = module;
            this.message = message;
        }
        public string Module() {
            return module;
        }
        public string Message()
        {
            return message;
        }
    }
}
