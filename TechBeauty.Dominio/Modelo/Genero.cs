using System.Collections.Generic;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Genero : IEntity
    {
        public int Id { get;  private set; }
        public string Valor { get; private set; }
        public List<Colaborador> Colaboradores { get; set; }

        public static Genero Criar(string valor)
        {
            Genero genero = new();
            
            genero.Valor = valor;

            return genero;
        }
        public static Genero Alterar(string valor, int id)
        {
            Genero genero = new();
            genero.Valor = valor;
            genero.Id = id;
            return genero;
        }
    }
}
