using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo.Financeiro
{
    public class Beneficio : IEntity
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<EspacoCliente> EspacosClientes { get; set; }//Navegação, não será populada

        public static BeneficioDto CoverteDto(Beneficio beneficio)
        {
            BeneficioDto dto = new();
            dto.Nome = beneficio.Nome;
            dto.Descricao = beneficio.Descricao;
            return dto;
        }

        public static Beneficio GerarBeneficio(BeneficioDto dto)
        {
            Beneficio beneficio = new();
            beneficio.Nome = dto.Nome;
            beneficio.Descricao = dto.Descricao;
            return beneficio;
        }
        public void AlterarBeneficio(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public static Beneficio Alterar(BeneficioDto dto)
        {
            Beneficio beneficio = new();
            if (dto.Nome != null)
            {
                beneficio.Nome = dto.Nome;
            }
            if (dto.Descricao != null)
            {
                beneficio.Descricao = dto.Descricao;
            }
            return beneficio;
        }
    }
}
