using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Eart.Areas.Membros.Models;
using Eart.Areas.Comportamentos.Models;

namespace Eart.Areas.Postagens.Models
{
    public class Postagem
    {
        [DisplayName("Id")]
        public long? PostagemId { get; set; }

        [DisplayName("Legenda")]
        [StringLength(100, ErrorMessage = "Sua legenda precisa ter no máximo {1} caracteres")]
        public string Texto { get; set; }

        [DisplayName("Data da postagem")]
        public DateTime Data { get; set; }

        public string FotoType { get; set; }

        public byte[] Foto { get; set; }

        public string FotoNome { get; set; }

        public long FotoTamanho { get; set; }

        public bool Curtida { get; set; }

        public long Cont_Curtida { get; set; }

        [DisplayName("Membro")]
        public long? MembroId { get; set; }

        public Membro Membro { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }

        public virtual ICollection<Curtida> Curtidas { get; set; }
    }
}

