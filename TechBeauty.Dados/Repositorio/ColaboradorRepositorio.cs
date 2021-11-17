using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dados;
using TechBeauty.Dominio.Dtos;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ColaboradorRepositorio : RepositorioBase<Colaborador>
    {
        public override int Incluir(Colaborador entity)
        {
            if (!context.Colaborador.Any(c => c.CPF.Equals(entity.CPF)))
            {
                return base.Incluir(entity);
            }
            throw new ArgumentException();
        }

        public List<ColaboradorReadDTO> PaginarInnerJoin(int skip, int take)
        {
            take = take > 0 ? take : 25;
            skip = skip >= 1 ? skip *= take : skip;

            var innerJoin = (from c in context.Colaborador
                             join e in context.Endereco on c.EnderecoId equals e.Id
                             orderby c.Id
                             select new { c, e }).Take(take).Skip(skip).ToList();

            List<ColaboradorReadDTO> dtos = new();
            foreach (var item in innerJoin)
            {
                Endereco endereco = item.e;
                Colaborador colaborador = item.c;
                ColaboradorReadDTO dto = new();
                dto.Bairro = endereco.Bairro;
                dto.Logradouro = endereco.Logradouro;
                dto.Cep = endereco.Cep;
                dto.Cidade = endereco.Cidade;
                dto.Complemento = endereco.Complemento;
                dto.CPF = colaborador.CPF;
                dto.DataNascimento = colaborador.DataNascimento;
                dto.GeneroId = colaborador.GeneroId;
                dto.Id = colaborador.Id;
                dto.Nome = colaborador.Nome;
                dto.Numero = endereco.Numero;
                dto.UF = endereco.UF;

                var contatos = context.Contato.Where(x => x.PessoaId == colaborador.Id).ToList();
                dto.Contatos = Contato.ConverteContato(contatos);
                dtos.Add(dto);
            }
            return dtos;
        }

        public ColaboradorReadDTO SelecaoUnica(int id)
        {
            if (context.Colaborador.Any(x => x.Id == id))
            {
                var innerJoin = (from c in context.Colaborador
                                 join e in context.Endereco on c.Id equals e.Id
                                 where c.Id == id
                                 orderby c.Id
                                 select new { c, e }).FirstOrDefault();

                Endereco endereco = innerJoin.e;
                Colaborador colaborador = innerJoin.c;

                var contatos = context.Contato.Where(x => x.PessoaId == colaborador.Id).ToList();

                return ColaboradorReadDTO.Unico(colaborador, endereco, Contato.ConverteContato(contatos));
            }
            else
            {
                throw new ArgumentException("Colaborador não encontrado!", nameof(id));
            }
        }
    }
}
