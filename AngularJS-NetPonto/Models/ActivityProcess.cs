using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJS_NetPonto.Models
{
    public class ActivityProcess
    {
        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Required]
        public int ProcessID { get; set; }
        
        [Required]
        public int ActivityID { get; set; }

        public virtual Process Process { get; set; }
        public virtual Activity Activity { get; set; }
    }
}