using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Entities;

namespace WebRequestsAPI.Models.Dtos
{
    public class TrialTrainingDto : BaseDto
    {
        [Required]
        public List<int> EducationId { get; set; }

    }
}
