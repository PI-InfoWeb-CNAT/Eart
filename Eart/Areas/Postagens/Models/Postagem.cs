using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Eart.Areas.Membros.Models;

namespace Eart.Areas.Postagens.Models
{
    public class Postagem
    {
        [DisplayName("Id")]
        public long? PostagemId { get; set; }

        [DisplayName("Legenda")]
        [StringLength(35, ErrorMessage = "Seu nome precisa ter no máximo {1} caracteres")]
        public string Texto { get; set; }

        [DisplayName("Data da postagem")]
        public DateTime Data { get; set; }

        public string FotoType { get; set; }

        public byte[] Foto { get; set; }

        public string FotoNome { get; set; }

        public long FotoTamanho { get; set; }

        [DisplayName("Membro")]
        public long? MembroId { get; set; }

        public Membro Membro { get; set; }
    }
}

