using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Dtos;

namespace WebRequestsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrialTrainingController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TrialTrainingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpPost("CreateTrialTraining")]
        public async Task<IActionResult> CreateTrialTraining([FromForm]TrialTrainingDto trialTrainingDto) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(trialTrainingDto);
            var data = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("BaseURL", data);
            return Ok();
        }
    }
}
