using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERTHSobes.Controllers
{   
    [ApiController]
    [Route("api/createobject")]
    public class СreateObjectController : ControllerBase
    {
        [HttpGet]
        public Guid Get()
        {
            return Guid.NewGuid();
        }
    }
}
