using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AngularJS_NetPonto.Models
{
    public class Process
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string description { get; set; }

        [Required]
        public string acronym { get; set; }
    }
}