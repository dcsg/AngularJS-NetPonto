using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJS_NetPonto.Models
{
    public class Process
    {
        [Required]
        public int ProcessID { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }
        
        [Required]
        public string acronym { get; set; }

        public virtual ICollection<ActivityProcess> ActivitiesProcesses { get; set; }
    }
}