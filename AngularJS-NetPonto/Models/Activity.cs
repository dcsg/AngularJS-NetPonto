using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AngularJS_NetPonto.Models
{
    public class Activity
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        // Navigation property
        public ICollection<ActivityProcess> ActivityProcesses { get; set; }
    }
}