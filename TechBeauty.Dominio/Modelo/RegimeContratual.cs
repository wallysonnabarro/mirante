using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class RegimeContratual
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
        public void AlterarRegimeContratual(string valor)
        {
            Valor = valor;
        }

    }



}
