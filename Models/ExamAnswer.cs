using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class ExamAnswer
    {
        [Key]
        public int ExamAnswerId { get; set; }
        [Required]
        public int ExamSubmissionId { get; set; }
        [Required]
        public int ExamQuestionId { get; set; }
        [Required]
        public string AnswerText { get; set; }

        public ExamSubmission ExamSubmission { get; set; }
        public ExamQuestion ExamQuestion { get; set; }
    }
}