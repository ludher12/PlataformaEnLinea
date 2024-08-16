using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class ExamSubmission
    {
        [Key]
        public int ExamSubmissionId { get; set; }
        [Required]
        public int ExamId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public DateTime SubmissionDate { get; set; }

        public Exam Exam { get; set; }
        public Student Student { get; set; }
        public ICollection<ExamAnswer> ExamAnswers { get; set; }
    }
}
