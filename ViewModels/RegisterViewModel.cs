using System.ComponentModel.DataAnnotations;

namespace PlataformaEnLinea.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Nombre(s)")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Apellido(s)")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Compare("Password", ErrorMessage = "Contraseñas diferentes")]
        public string ConfirmPassword { get; set; }
    }
}
