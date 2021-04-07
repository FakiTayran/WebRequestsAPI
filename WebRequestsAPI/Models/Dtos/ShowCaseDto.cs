using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Entities;
using WebRequestsAPI.Models.Enums;

namespace WebRequestsAPI.Models.Dtos
{
   
    public class ShowCaseDto : BaseDto
    {
        [Required]
        public RequestType RequestType { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public int EducationId { get; set; }

        public EducationDto Education { get; set; }
    }
   
}
