using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookMemberGeneric
{
    internal class GenericResponse<TData>
    {
        
            public bool Success { get; set; }
            public string Message { get; set; }
            public TData Data { get; set; }
        
    }
}
