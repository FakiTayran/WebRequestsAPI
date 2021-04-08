using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Entities;

namespace WebRequestsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarlyRegisterController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EarlyRegisterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpPost("CreateEarlyRegister")]
        public async Task<IActionResult> CreateEarlyRegister([FromForm]EarlyRegisterDto earlyRegisterDto) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(earlyRegisterDto);
            var data = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("BaseURL", data);
            return Ok();

        }
    }
}
