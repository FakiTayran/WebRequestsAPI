using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebRequestsAPI.Models.Enums
{
    public enum TimeInterval
    {
        [Display(Name = "10:00-12:00")]
        _1012,

        [Display(Name = "13:00-15:00")]
        _1315,

        [Display(Name = "15:00-17:00")]
        _1517,

        [Display(Name ="17:00-19:00")]
        _1719
        
    }
}
