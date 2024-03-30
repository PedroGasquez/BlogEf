using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "O E-mail e obrigatorio")]
    [EmailAddress(ErrorMessage = "O E-mail e invalido")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Informe a senha")]
    public string Password { get; set; }
}