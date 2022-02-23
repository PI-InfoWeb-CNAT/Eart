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
    public class Pesquisa
    {
        [DisplayName("Id")]
        public long? PesquisaId { get; set; }

        public string ItemPesquisa { get; set; }
        public virtual ICollection<Membro> Membros { get; set; }

        public virtual ICollection<Postagem> Postagens { get; set; }


    }
}