using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Genero
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
        public void Alterar(string valor)
        {
            Valor = valor;
        }
    }
}
