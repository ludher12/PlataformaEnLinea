using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class CoursePricing
    {
        [Key]
        public int CoursePricingId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int PaymentOptionId { get; set; }
        [Required]
        public decimal Price { get; set; }

        public Course Course { get; set; }
        public PaymentOption PaymentOption { get; set; }
    }
}