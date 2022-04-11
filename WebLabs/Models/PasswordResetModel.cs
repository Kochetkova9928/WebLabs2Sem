using System.ComponentModel.DataAnnotations;

namespace WebLabs.Models
{
    public class PasswordResetModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "�� ������ email")]
        public string Email { get; set; }
    }
}
