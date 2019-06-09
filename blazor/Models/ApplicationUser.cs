using System.ComponentModel.DataAnnotations;

namespace blazor.Models
{
    public class ApplicationUserModel
    {
        
        public string id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string eMail { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}