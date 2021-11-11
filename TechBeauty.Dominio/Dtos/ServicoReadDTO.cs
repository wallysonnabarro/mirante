using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ServicoReadDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public int DuracaoEmMin { get; set; }

        public static object Paginar(List<Servico> servicos)
        {
            List<ServicoReadDTO> dto = new();
            foreach (var item in servicos)
            {
                ServicoReadDTO servicoRead = new();
                servicoRead.Id = item.Id;
                servicoRead.Nome = item.Nome;
                servicoRead.Preco = item.Preco;
                servicoRead.DuracaoEmMin = item.DuracaoEmMin;
                servicoRead.Descricao = item.Descricao;
                dto.Add(servicoRead);
            }
            return dto;
        }
    }
}
