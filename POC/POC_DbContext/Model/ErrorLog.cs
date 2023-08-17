using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_DbContext.Model
{
    public class ErrorLog
    {
        [Key]
        public int Id { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public string ControllerName { get; set; }

        public DateTime InsertDateTime { get; set; }
    }
}
