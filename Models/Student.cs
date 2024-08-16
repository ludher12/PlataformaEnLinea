using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Nombre(s)")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido(s)")]
        public string LastName { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        public ICollection<ExamSubmission> ExamSubmissions { get; set; }
    }
}
