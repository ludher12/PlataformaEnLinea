using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Lenguaje")]
        public string Name { get; set; }
        [Required]
        [StringLength(5)]
        public string Code { get; set; } // e.g., "en", "es", "fr"
    }
}
