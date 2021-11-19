using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Eart.Areas.Membros.Models;

namespace Eart.Persistencia.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext() : base("MembroDB")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Membro> Membros { get; set; }
    }
}