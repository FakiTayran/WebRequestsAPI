using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Entities;
using WebRequestsAPI.Models.Enums;

namespace WebRequestsAPI.Models.Dtos
{
    public class InformationAndAppointmentDto : BaseDto
    {
        [Required]
        public List<int> EducationId { get; set; }

        [Required]
        public RequestType RequestType { get; set; }

        [Required]
        public List<EducationType> EducationTypes { get; set; }

        public string Message { get; set; }

        public PlaceOfMeeting PlaceOfMeeting { get; set; }

        public DateTime? Date { get; set; }

        public TimeInterval TimeInterval { get; set; }

    }
}
