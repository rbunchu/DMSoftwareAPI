using System.ComponentModel.DataAnnotations;

namespace DMSoftwareAPI.Models
{
    public class ContactFormData
    {
        public string CaptchaToken { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
