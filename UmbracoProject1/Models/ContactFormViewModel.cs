using System.ComponentModel.DataAnnotations;

namespace UmbracoProject1.Models
{
    public class ContactFormViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Message { get; set; }

        public string RecaptchaToken { get; set; }

    }
}
