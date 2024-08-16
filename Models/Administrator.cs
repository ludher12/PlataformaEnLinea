using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Administrator
    {
        [Key]
        public int AdministratorId { get; set; }
        [Required]
        [Display(Name = "Nombre(s)")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido(s)")]
        public string LastName { get; set; }
        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
