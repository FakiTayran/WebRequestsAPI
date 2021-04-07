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
    public class InformationAndAppointmentController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public InformationAndAppointmentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpPost]
        public async Task<IActionResult> CreateInformationAndAppointment([FromForm]InformationAndAppointmentDto informationAndAppointmentDto) 
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(informationAndAppointmentDto);
            var data = new StringContent(jsonData, Encoding.UTF8, "application/json");
            if (informationAndAppointmentDto.RequestType == Models.Enums.RequestType.Enterprise)
            {
                await client.PostAsync("fowURL", data);
                return Ok();
            }
            else if (informationAndAppointmentDto.RequestType == Models.Enums.RequestType.Personal)
            {
                await client.PostAsync("baseURL", data);
                return Ok();
            }

            return BadRequest();
        } 
    }
}
