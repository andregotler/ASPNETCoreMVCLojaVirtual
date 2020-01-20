using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models
{
    public class ErroViewModel
    {
            public string requestId { get; set; }

        public bool ShowRequestId => !String.IsNullOrEmpty(requestId);
    }
}
