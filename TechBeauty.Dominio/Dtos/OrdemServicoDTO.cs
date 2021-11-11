using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class OrdemServicoDTO
    {
        [Required(ErrorMessage = "O campo 'PrecoTotal' da OrdemServico é obrigatório!")]
        public decimal PrecoTotal { get; set; }

        [Required(ErrorMessage = "O campo 'DuracaoTotal' da OrdemServico é obrigatório!")]
        public int DuracaoTotal { get; set; }


        public static OrdemServicoDTO CriarOS(OrdemServicoDTO os)
        {
            OrdemServicoDTO dto = new();
            dto.PrecoTotal = os.PrecoTotal;
            dto.DuracaoTotal = os.DuracaoTotal;
            return dto;
        }
    }
}
