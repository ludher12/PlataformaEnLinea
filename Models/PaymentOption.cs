using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class PaymentOption
    {
        [Key]
        public int PaymentOptionId { get; set; }
        [Required]
        public string Name { get; set; } // e.g., "Per Course", "Monthly Subscription", "Unlimited Access"

        public ICollection<CoursePricing> CoursePricings { get; set; }
    }
}
