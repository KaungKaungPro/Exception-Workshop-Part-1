using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionWorkshop;

internal class BadTriangleException : Exception
{
    public BadTriangleException(string message) : base(message) 
    { 

    }
}
