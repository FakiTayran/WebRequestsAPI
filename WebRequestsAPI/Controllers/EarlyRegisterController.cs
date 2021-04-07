using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Entities;

namespace WebRequestsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarlyRegisterController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateEarlyRegister([FromForm]EarlyRegisterDto earlyRegisterDto) 
        { 
            
        
        }
    }
}
