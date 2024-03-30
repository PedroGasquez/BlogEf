using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome e obrigatorio")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "O E-mail e obrigatorio")]
    [EmailAddress(ErrorMessage = "O E-mail e invalido")]
    public string Email { get; set; }
}