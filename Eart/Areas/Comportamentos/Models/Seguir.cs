using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eart.Areas.Comportamentos.Models
{
    public class Seguir
    {
        public long? SeguirId { get; set; }
        public long? SeguindoId { get; set; }

        public long? SeguidorId { get; set; }
    }
}