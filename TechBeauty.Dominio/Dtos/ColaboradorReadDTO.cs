using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class ColaboradorReadDTO
    {
        public int Id { get; set; }
        public string NomeSocial { get; set; }
        public string CarteiraTrabalho { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public int GeneroId { get; set; }
        public int EscalaId { get; set; }


        public static object Paginar(List<Colaborador> colaboradores)
        {
            List<ColaboradorReadDTO> dto = new();
            foreach (var item in colaboradores)
            {
                ColaboradorReadDTO colaboradorRead = new();
                colaboradorRead.Id = item.Id;
                colaboradorRead.NomeSocial = item.NomeSocial;
                
                dto.Add(colaboradorRead);
            }
            return dto;
        }
    }
}
