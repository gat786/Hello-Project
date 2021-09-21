using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Project.Models
{
    /// <summary>
    /// Request body for the Hello Api
    /// </summary>
    public class HelloRequest
    {
        [Required]
        public String Name { get; set; }
    }
}
