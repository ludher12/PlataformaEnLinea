using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class ExamQuestion
    {
        [Key]
        public int ExamQuestionId { get; set; }
        [Required]
        public int ExamId { get; set; }
        [Required]
        public int QuestionTypeId { get; set; }
        [Required]
        public string QuestionText { get; set; }

        public Exam Exam { get; set; }
        public QuestionType QuestionType { get; set; }
        public ICollection<ExamOption> ExamOptions { get; set; } // If multiple choice
    }
}
