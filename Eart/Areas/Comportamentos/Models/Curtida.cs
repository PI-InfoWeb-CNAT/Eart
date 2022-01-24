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
    public class Curtida
    {
        [DisplayName("Id")]
        public long? CurtidaId { get; set; }

        [DisplayName("Data da curtida")]
        public DateTime Data { get; set; }

        //public bool Curtir { get; set; }

        [DisplayName("Postagem")]
        public long? PostagemId { get; set; }

        public Postagem Postagem { get; set; }

        [DisplayName("Membro")]
        public long? MembroId { get; set; }

        public Membro Membro { get; set; }
    }
}