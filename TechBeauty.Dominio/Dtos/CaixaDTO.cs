using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    public class CaixaDTO
    {
        [StringLength(50, ErrorMessage = "Quantidade máximo de caracteres = 50")]
        [Required(ErrorMessage = "O campo 'SaldoInicial' do caixa é obrigatório!")]
        public decimal SaldoInicial { get; set; }

  
        public int UsuarioID { get; set; }


        public static CaixaDTO CriarCaixa(CaixaDTO caixa)
        {
            CaixaDTO dto = new();
            dto.SaldoInicial= caixa.SaldoInicial;
            dto.UsuarioID = caixa.UsuarioID;
            return dto;
        }


    }
}
