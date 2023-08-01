using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityPack.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base("Cannot find") {
        }

        public NotFoundException(string message) : base($"{message} unable to find")
        {

        }
    }
}
