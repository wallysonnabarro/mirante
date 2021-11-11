﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Dtos
{
    class ContatoDTO
    {
        [StringLength(256, ErrorMessage = "Quantidade máximo de caracteres = 256")]
        [Required(ErrorMessage = "O campo 'Valor' do contato é obrigatório!")]
        public string Valor { get; set; }


        public static ContatoDTO CriarContato(ContatoDTO contato)
        {
            ContatoDTO dto = new();
            dto.Valor = contato.Valor;
            return dto;
        }
    }
}
