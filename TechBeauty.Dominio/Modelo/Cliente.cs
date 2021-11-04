using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa
    {
        public List<OrdemServico> OrdensServicos { get; set; }
             
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
