using System;
using System.ComponentModel.DataAnnotations;

namespace WebLabs.Models
{
    public class SignUpFirstViewModel
    {
        [Required(ErrorMessage = "�� ������� ���")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "�� ������� �������")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "�� ������ ���� ��������")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "�� ������ ���")]
        public Gender Gender { get; set; }
    }
}
