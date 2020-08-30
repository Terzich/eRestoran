using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class UserInsertRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]

        public DateTime? DateOfBirth { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]

        public string ConfirmationPassword { get; set; }
        [Required]

        public string Username { get; set; }

    }
}
