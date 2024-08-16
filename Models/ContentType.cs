using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class ContentType
    {
        [Key]
        public int ContentTypeId { get; set; }
        [Required]
        public string Name { get; set; } // e.g., "Video", "Document", "Link"
    }
}
