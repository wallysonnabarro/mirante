﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ColaboradorRepositorio
    {
        private readonly Context context;

        public ColaboradorRepositorio()
        {
            context = new();
        }

        public void Incluir(Colaborador colaborador)
        {
            context.Colaborador.Add(colaborador);
            context.SaveChanges();
        }

        public void Alterar(int id, Colaborador colaborador)
        {
            context.Colaborador.Update(colaborador);
            context.SaveChanges();
        }

        public Colaborador PegarColaborador(int id)
        {
            return context.Colaborador.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Colaborador.Remove(PegarColaborador(id));
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
