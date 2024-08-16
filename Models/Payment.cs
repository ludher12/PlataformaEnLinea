using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CoursePricingId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public int PaymentStatusId { get; set; }

        public IdentityUser User { get; set; }
        public CoursePricing CoursePricing { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
