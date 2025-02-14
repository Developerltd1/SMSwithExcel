using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MsgTemplete
{
    public class MsgTempleteMdl
    {
        #region Create
        public class Request
        {
            public int MessageId { get; set; }
            public string MessageText { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
            public bool Status { get; set; }
            public string Description { get; set; } = string.Empty;
            public string Refrence { get; set; } = string.Empty;
            public string MsgType { get; set; } = string.Empty;

        }
        public class Response
        {
            public int MessageId { get; set; }
            public string MessageText { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
            public bool Status { get; set; }
            public string Description { get; set; } = string.Empty;
            public string Refrence { get; set; } = string.Empty;
            public string MsgType { get; set; } = string.Empty;
        }
        #endregion

    }
}
