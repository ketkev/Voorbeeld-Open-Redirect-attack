using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OpenRedirect.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
