using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Dtos;

namespace WebRequestsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowCaseController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateShowCase([FromForm]ShowCaseDto showCaseDto) 
        {
            if (showCaseDto.RequestType == Models.Enums.RequestType.Enterprise)
            {
                //FOW
            }
            else
            {
                //BASE
            }
        }
    }
}
