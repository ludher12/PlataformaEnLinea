using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class QuestionType
    {
        [Key]
        public int QuestionTypeId { get; set; }
        [Required]
        public string Name { get; set; } // e.g., "MultipleChoice", "TrueFalse", "Essay"
    }
}
