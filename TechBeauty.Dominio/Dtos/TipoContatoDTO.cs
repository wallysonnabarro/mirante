using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class TipoContatoDTO
    {
        [StringLength(30, ErrorMessage = "Quantidade máximo de caracteres = 30")]
        [Required(ErrorMessage = "O campo 'Valor' do Tipo contato é obrigatório!")]
        public string Valor { get;  set; }
    }
}
