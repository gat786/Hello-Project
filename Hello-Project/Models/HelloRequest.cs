using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Project.Models
{
    public class HelloRequest
    {
        [Required]
        public String Name { get; set; }
    }
}
