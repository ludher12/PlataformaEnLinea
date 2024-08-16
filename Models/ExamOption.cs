using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class ExamOption
    {
        [Key]
        public int ExamOptionId { get; set; }
        [Required]
        public int ExamQuestionId { get; set; }
        [Required]

        public string OptionText { get; set; }
        [Required]
        public bool IsCorrect { get; set; }

        public ExamQuestion ExamQuestion { get; set; }
    }
}
