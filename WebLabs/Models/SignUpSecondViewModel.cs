using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebLabs.Models
{
    public class SignUpSecondViewModel
    {
        [Required(ErrorMessage = "�� ������� ���")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "�� ������� �������")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "�� ������� ���� ��������")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "�� ������ ���")]
        public Gender Gender { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "�� ������ email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "�� ������ ������")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "������ �� ���������")]
        public string ConfirmPassword { get; set; }
        public bool IsRemember { get; set; }
    }
}
