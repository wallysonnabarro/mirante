using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class UsuarioDTO
    {

        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'Nome' de usuario é obrigatório!")]
        public string Nome { get; set; }

        [StringLength(5, ErrorMessage = "Quantidade máximo de caracteres = 5")]
        [Required(ErrorMessage = "O campo 'Password' de usuario é obrigatório!")]
        public string Password { get; set; }

        public int CargoId { get; set; }

    }
}
