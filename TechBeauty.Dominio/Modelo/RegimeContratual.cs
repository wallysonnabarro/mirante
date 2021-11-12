using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class RegimeContratual : IEntity
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public List<ContratoTrabalho> ContratosDeTrabalho { get; set; } // Navegação  - relação (1,n) não será populada

        public static RegimeContratual Criar(string valor)
        {
            RegimeContratual regime = new();

            regime.Valor = valor;

            return regime;
        }

        public static RegimeContratual Criar(RegimeContratualDTO regime)
        {
            throw new NotImplementedException();
        }

        public void AlterarRegimeContratual(string valor)
        {
            Valor = valor;
        }

    }



}
