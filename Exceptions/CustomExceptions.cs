using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class CustomExceptions<CustomErrorCode> : Exception where CustomErrorCode : struct
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
