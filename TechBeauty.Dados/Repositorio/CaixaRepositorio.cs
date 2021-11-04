﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CaixaRepositorio
    {
        private readonly Context context;

        public CaixaRepositorio()
        {
            context = new();
        }

        public void AbrirCaixa(Caixa caixa)
        {
            context.Caixa.Add(caixa);
            context.SaveChanges();
        }

        public void FecharCaixa(int id)
        {
            var pagamentos = context.Pagamento.Where(x => x.Id == id).ToList();
            context.Caixa.FirstOrDefault(x => x.Id == id).FecharCaixa(pagamentos);
            context.SaveChanges();
        }
    }
}