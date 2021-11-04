using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string  Cidade { get; private set; }
        public string UF { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
        public string Bairro { get; private set; }
        public ICollection<Colaborador> Colaboradores { get; set; }


        public static Endereco Criar(int id, string logradouro, string cidade, 
            string uf, string numero, string complemento, string cep, string bairro)
        {
            Endereco endereco = new Endereco();
            endereco.Id = id;
            endereco.Logradouro = logradouro;
            endereco.Cidade = cidade;
            endereco.UF = uf;
            endereco.Numero = numero;
            endereco.Complemento = complemento;
            endereco.Cep = cep;
            endereco.Bairro = bairro;
            return endereco;
        }
        public void AlterarEndereco(Endereco endereco)
        {
            
            Logradouro = endereco.Logradouro;
            Cidade = endereco.Cidade;
            UF = endereco.UF;
            Numero = endereco.Numero;
            Complemento = endereco.Complemento;
            Cep = endereco.Cep;
            Bairro = endereco.Bairro;
        }
    }
}
