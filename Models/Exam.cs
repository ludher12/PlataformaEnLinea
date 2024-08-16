using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Titulo del examen")]
        public string Title { get; set; }
        [Required]
        public DateTime ScheduledDate { get; set; }
        [Required]
        public TimeSpan Duration { get; set; }

        public Course Course { get; set; }
        public ICollection<ExamQuestion> ExamQuestions { get; set; }
        public ICollection<ExamSubmission> ExamSubmissions { get; set; }
    }
}
