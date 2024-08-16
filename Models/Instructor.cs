using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorId { get; set; }
        [Required]
        [Display(Name = "Nombre(s)")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido(s)")]
        public string LastName { get; set; }
        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public ICollection<Course> CoursesCreated { get; set; }
    }
}
