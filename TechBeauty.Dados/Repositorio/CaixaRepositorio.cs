using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CaixaRepositorio : RepositorioBase<Caixa>
    {
        

        public void FecharCaixa(int id)
        {
            var pagamentos = context.Pagamento.Where(x => x.Id == id).ToList();
            context.Caixa.FirstOrDefault(x => x.Id == id).FecharCaixa(pagamentos);
            context.SaveChanges();
        }

        public void RegistrarRetiradasDiarias(int id, decimal retirada)
        {
            context.Caixa.FirstOrDefault(x => x.Id == id).RegistrarRetiradasDiarias(retirada);
            context.SaveChanges();
        }
    }
}
