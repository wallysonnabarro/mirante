﻿using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa,IEntity
    {
        public List<OrdemServico> OrdensServicos { get; set; }//Navegação, não é populada
        public List<EspacoCliente> EspacoCliente { get; set; }//Navegação, não é populada
             
        public static Cliente Criar(Cliente clienteDto)
        {
            Cliente cliente = new();
            cliente.Nome = clienteDto.Nome;
            cliente.CPF = clienteDto.CPF;
            cliente.DataNascimento = clienteDto.DataNascimento;
            return cliente;
        }
        public void AlterarCliente(Cliente cliente)
        {
            Nome = cliente.Nome;
            CPF = cliente.CPF;
            DataNascimento = cliente.DataNascimento;
        }
    }
}
