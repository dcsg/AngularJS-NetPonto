using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJS_NetPonto.Models
{
    public class Activity
    {
        [Required]
        public int ActivityID { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        [Display(Name="Processes")]
        public virtual ICollection<ActivityProcess> ActivitiesProcesses { get; set; }
    }
}