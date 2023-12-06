using Microsoft.AspNetCore.Identity;

namespace UsuarioApi.Data.Models
{
    public class Usuario : IdentityUser
    {
        public Usuario() : base()
        {
        }

        public DateTime DataNascimento { get; set; }
    }
}
