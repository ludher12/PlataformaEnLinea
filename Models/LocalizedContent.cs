using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class LocalizedContent
    {
        [Key]
        public int LocalizedContentId { get; set; }
        [Required]
        public int CourseModuleId { get; set; }
        [Required]
        public int LanguageId { get; set; }

        public string TranslatedContent { get; set; }

        public CourseModule CourseModule { get; set; }
        public Language Language { get; set; }
    }
}
