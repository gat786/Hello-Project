using Hello_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Project.Controllers
{
    /// <summary>
    /// Takes name as a post body data and returns Hello Birthday, ${name}! as response
    /// </summary>
    [ApiController]
    [Route("hello")]
    public class HelloController: ControllerBase
    {
        [HttpPost]
        public ActionResult<HelloResponse> Hello(HelloRequest requestParams)
        {
            return new HelloResponse { Message = $"Happy Birthday, {requestParams.Name}!" };
        }
    }
}
