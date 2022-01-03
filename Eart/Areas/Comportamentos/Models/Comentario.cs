using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Eart.Areas.Membros.Models;
using Eart.Areas.Postagens.Models;

namespace Eart.Areas.Comportamentos.Models
{
    public class Comentario
    {
        [DisplayName("Id")]
        public long? ComentarioId { get; set; }

        [DisplayName("Comentário")]
        [StringLength(100, ErrorMessage = "Seu comentário precisa ter no entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Texto { get; set; }

        [DisplayName("Data do comentário")]
        public DateTime Data { get; set; }

        [DisplayName("Postagem")]
        public long? PostagemId { get; set; }

        public Postagem Postagem { get; set; }

        [DisplayName("Membro")]
        public long? MembroId { get; set; }

        public Membro Membro { get; set; }
    }
}

