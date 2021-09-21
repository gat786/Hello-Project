using Hello_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hello_Project.Controllers
{
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
