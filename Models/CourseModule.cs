using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class CourseModule
    {
        [Key]
        public int CourseModuleId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string ModuleTitle { get; set; }

        public Course Course { get; set; }
        public ICollection<CourseMaterial> CourseMaterials { get; set; }
    }
}
