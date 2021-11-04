using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio
    {
        private readonly Context context;

        public GeneroRepositorio()
        {
            context = new();
        }

        public int Incluir(GeneroDto generoDto)
        {
            Genero genero = Genero.Criar(generoDto.Valor);
            context.Genero.Add(genero);
            context.SaveChanges();
            return genero.Id;
        }

        public void Alterar(int id, string genero)
        {
            context.Genero.FirstOrDefault(x => x.Id == id).Alterar(genero);
            context.SaveChanges();
        }

        public Genero PegarGenero(int id)
        {
            return context.Genero.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            context.Genero.Remove(context.Genero.First(x => x.Id == id));
            context.SaveChanges();
        }

        public List<GeneroDto> Tabela()
        {
            List<Genero> generos = context.Genero.ToList();
            List<GeneroDto> dtos = new();
            foreach (var genero in generos)
            {
                dtos.Add(GeneroDto.CriarGenero(genero.Valor));
            }
            return dtos;
        }
    }
}
