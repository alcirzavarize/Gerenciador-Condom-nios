﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }

        [Required(ErrorMessage = " Este campo {0}é obrigatório")]
        [Range(0, 1000, ErrorMessage ="Valou Inválido")]
        public int Numero { get; set; }

        [Required(ErrorMessage = " Este campo {0}é obrigatório")]
        [Range(0, 10, ErrorMessage = "Valou Inválido")]
        public int Andar { get; set; }

        public string Foto { get; set; }

        public string MoradorId { get; set; }

        public virtual Usuario Morador { get; set; }

        public string ProprietarioId { get; set; }

        public virtual Usuario Proprietario { get; set; }

    }
}
