using System;
using System.ComponentModel.DataAnnotations;

namespace WebLabs.Models
{
    public class SignUpFirstViewModel
    {
        [Required (ErrorMessage = "Не указано имя")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "Не указана фамилия")]
        public string LastName { get; set; }

        [Required (ErrorMessage = "Не указан день рожденья")]
        public DateTime Birthday { get; set; }

        [Required (ErrorMessage = "Не указан пол")]
        public Gender Gender { get; set; }
    }
}
