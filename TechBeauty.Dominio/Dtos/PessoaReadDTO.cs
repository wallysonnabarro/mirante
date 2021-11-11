using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class PessoaReadDTO
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string CPF { get;  set; }
        public DateTime DataNascimento { get;  set; }


        public static object Paginar(List<Pessoa> pessoas)
        {
            List<PessoaReadDTO> dto = new();
            foreach (var item in pessoas)
            {
                PessoaReadDTO pessoaRead = new();
                pessoaRead.Id = item.Id;
                pessoaRead.Nome = item.Nome;
                pessoaRead.CPF = item.CPF;
                pessoaRead.DataNascimento = item.DataNascimento;
                dto.Add(pessoaRead);
            }
            return dto;
        }
    }
}
