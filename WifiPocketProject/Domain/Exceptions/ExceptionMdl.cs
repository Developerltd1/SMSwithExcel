using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class ExceptionMdl
    {
        public class Request
        {
            public int ErrorId { get; set; } // Assuming it's an identity column
            public string ErrorMessage { get; set; } = string.Empty;
            public string ErrorInnerMessage { get; set; } = string.Empty;
            public string FuncationName { get; set; } = string.Empty;
            public DateTime EntryDate { get; set; }
            public string SheetName { get; set; } = string.Empty;
            public string SheetSNo { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
        }
        public class Response
        {

        }

    }
}
