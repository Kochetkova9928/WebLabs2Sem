using System.ComponentModel.DataAnnotations;

namespace WebLabs.Models
{
    public class VerifyPasswordResetModel
    {
        [Required]
        public string Code { get; set; }
    }
}
