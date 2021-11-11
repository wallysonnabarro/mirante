using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Dtos
{
    class ColaboradorReadDTO
    {
        public int Id { get; set; }
        //public string CarteiraTrabalho { get;  set; }
        
        public string NomeSocial { get; private set; }
        

        public static object Paginar(List<ColaboradorReadDTO> colaboradores)
        {
            List<ColaboradorReadDTO> dto = new();
            foreach (var item in colaboradores)
            {
                ColaboradorReadDTO colaboradorRead = new();
                colaboradorRead.Id = item.Id;
                colaboradorRead.NomeSocial = item.NomeSocial;
                
                dto.Add(colaboradorRead);
            }
            return dto;
        }
    }
}
