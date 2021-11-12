﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    public class OrdemServicoReadDTO
    {
        public int Id { get;  set; }
        public decimal PrecoTotal { get;  set; }
        public int DuracaoTotal { get;  set; }


        public static object Paginar(List<OrdemServico> ordemServicos)
        {
            List<OrdemServicoReadDTO> dto = new();
            foreach (var item in ordemServicos)
            {
                OrdemServicoReadDTO ordemServicoRead = new();
                ordemServicoRead.Id = item.Id;
                ordemServicoRead.PrecoTotal = item.PrecoTotal;
                ordemServicoRead.DuracaoTotal = item.DuracaoTotal;
                dto.Add(ordemServicoRead);
            }
            return dto;
        }
    }
}
