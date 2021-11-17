using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Interfaces;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa, IEntity
    {
        public List<OrdemServico> OrdensServicos { get; set; }//Navegação, não é populada
        public List<EspacoCliente> EspacoCliente { get; set; }//Navegação, não é populada

        public static Cliente Criar(ClienteDTO clienteDto)
        {
            Cliente cliente = new();
            cliente.Nome = clienteDto.Nome;
            cliente.CPF = clienteDto.CPF;
            cliente.DataNascimento = clienteDto.DataNascimento;
            return cliente;
        }

        public static Cliente AlterarCliente(ClienteDTO dto, int id)
        {
            Cliente cliente = new();
            cliente.Id = id;
            cliente.Nome = dto.Nome;
            cliente.CPF = dto.CPF;
            cliente.DataNascimento = dto.DataNascimento;
            return cliente;
        }
    }
}
