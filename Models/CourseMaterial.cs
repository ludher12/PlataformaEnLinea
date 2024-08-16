using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class CourseMaterial
    {
        [Key]
        public int CourseMaterialId { get; set; }
        [Required]
        public int CourseModuleId { get; set; }
        [Required]
        public int ContentTypeId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public string ContentUrl { get; set; }

        public CourseModule CourseModule { get; set; }
        public ContentType ContentType { get; set; }
    }
}
