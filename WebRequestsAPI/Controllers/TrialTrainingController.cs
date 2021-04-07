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
    public class TrialTrainingController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateTrialTraining([FromForm]TrialTrainingDto trialTrainingDto) 
        {
           
            
        }
    }
}
