using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class RegimeContratual : IEntity
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public List<ContratoTrabalho> ContratosDeTrabalho { get; set; } // Navegação  - relação (1,n) não será populada


        public static RegimeContratual Criar(RegimeContratualDTO dto)
        {
            RegimeContratual regime = new();

            regime.Valor = dto.Valor;

            return regime;
        }

        public static RegimeContratual AlterarRegimeContratual(int id, string valor)
        {
            RegimeContratual regime = new();
            regime.Id = id;
            regime.Valor = valor;
            return regime;
        }

    }



}
