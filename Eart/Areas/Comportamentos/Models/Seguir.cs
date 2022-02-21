using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eart.Areas.Membros.Models;

namespace Eart.Areas.Comportamentos.Models
{
    public class Seguir
    {
        public long? SeguirId { get; set; }
        public Membro Seguindo { get; set; }

        public Membro Seguidor { get; set; }
    }
}