using System;
using Microsoft.AspNetCore.Mvc;

namespace TokenGenerator.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet]
        public dynamic Get()
        {
            return new
            {
                Guid = Guid.NewGuid().ToString(),
                Expires = DateTime.Now.AddDays(1),
                Issuer = Environment.MachineName,
                Version = "2.0"
            };
        }
    }
}
