using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [StringLength(150)]
        [Display(Name = "Mensaje")]
        public string Message { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public bool IsRead { get; set; }

        public IdentityUser User { get; set; }
    }
}
