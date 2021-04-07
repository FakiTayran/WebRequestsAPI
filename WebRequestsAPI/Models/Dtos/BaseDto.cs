using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebRequestsAPI.Models.Dtos;

namespace WebRequestsAPI.Models.Entities
{
    public class BaseDto
    {
        [Required(ErrorMessage = "Namespace is required.")]
        [StringLength(50,MinimumLength = 2, ErrorMessage = "The namespace must contain a maximum of 50 and a minimum of 2 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "The surname field must contain a maximum of 50 and a minimum of 2 characters.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Phone field is required.")]
        [StringLength(15,ErrorMessage = "Please enter a valid number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email field is required.")]
        [StringLength(50,MinimumLength = 5, ErrorMessage = "Email field must contain a maximum of 50 and a minimum of 5 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "KVKK Approve is Required")]
        public bool KVKKApprove { get; set; }

        [Required(ErrorMessage = "Place Information is Required")]
        public int PlaceInformationId { get; set; }

        public PlaceInformationDto PlaceInformation { get; set; }

    }

  
}


