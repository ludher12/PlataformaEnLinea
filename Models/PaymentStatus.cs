using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.Models
{
    public class PaymentStatus
    {
        [Key]
        public int PaymentStatusId { get; set; }
        [Required]
        public string Name { get; set; } // e.g., "Pending", "Completed", "Failed"
    }
}
