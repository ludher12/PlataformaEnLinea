using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class DiscussionPost
    {
        [Key]
        public int DiscussionPostId { get; set; }
        [Required]
        public int DiscussionForumId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public DiscussionForum DiscussionForum { get; set; }
        public IdentityUser User { get; set; }
    }
}