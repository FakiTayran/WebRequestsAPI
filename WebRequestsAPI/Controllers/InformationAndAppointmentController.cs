using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Dtos;

namespace WebRequestsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationAndAppointmentController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> CreateInformationAndAppointment([FromForm]InformationAndAppointmentDto informationAndAppointmentDto) 
        {
            HttpClient client = new HttpClient();
            await client.PostAsync("",new HttpContent {Headers,})
            if (informationAndAppointmentDto.RequestType == Models.Enums.RequestType.Enterprise)
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
