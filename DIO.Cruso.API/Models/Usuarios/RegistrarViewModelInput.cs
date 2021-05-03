using System.ComponentModel.DataAnnotations;

namespace DIO.Cruso.API.Models.Usuarios
{
    public class RegistrarViewModelInput
    {
        [Required(ErrorMessage = "O Login é Obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O E-mail é Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é Obrigatória")]
        public string Senha { get; set; }
    }
}
