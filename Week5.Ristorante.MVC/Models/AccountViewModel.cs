using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week5.Ristorante.MVC.Models
{
    public class AccountViewModel
    {
        [Required, DataType(DataType.EmailAddress), DisplayName("Email")]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
