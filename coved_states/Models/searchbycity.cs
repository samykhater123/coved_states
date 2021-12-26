using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.Models
{
    public class searchbycity
    {
        [Required (ErrorMessage ="enter the name of city")]
        [StringLength(30,MinimumLength =1,ErrorMessage ="the city name is not correct")]
        public string namecity { get; set; }
       
    }
}
