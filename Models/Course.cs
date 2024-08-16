using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public int InstructorId { get; set; }
        [Required]
        [Display(Name = "Título")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        [StringLength(300)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public int Capacity { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        public ICollection<CourseModule> CourseModules { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
