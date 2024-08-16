using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class DiscussionForum
    {
        [Key]
        public int DiscussionForumId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public string Topic { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public Course Course { get; set; }
        public ICollection<DiscussionPost> DiscussionPosts { get; set; }
    }
}
