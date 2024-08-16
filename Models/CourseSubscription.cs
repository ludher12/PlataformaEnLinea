using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class CourseSubscription
    {
        [Key]
        public int CourseSubscriptionId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int PaymentOptionId { get; set; }
        public DateTime SubscriptionStartDate { get; set; }
        public DateTime SubscriptionEndDate { get; set; }

        public IdentityUser User { get; set; }
        public Course Course { get; set; }
        public PaymentOption PaymentOption { get; set; }
    }
}
