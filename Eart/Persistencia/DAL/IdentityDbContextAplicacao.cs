using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Eart.Areas.Membros.Models;

namespace Eart.Persistencia.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAplicacao() : base("IdentityDb")
        { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(new IdentityDbInit());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }
        public class IdentityDbInit : DropCreateDatabaseIfModelChanges<IdentityDbContextAplicacao>
        {
        }

        public DbSet<Membro> Membros { get; set; }

        public IQueryable<Membro> ObterMembrosClassificadosPorNome()
        {
            return Membros.OrderBy(m => m.Nome);
        }
        public Membro ObterMembroPorId(long id)
        {
            return Membros.Where(m => m.MembroId == id).First();
        }
        public void GravarMembro(Membro membro)
        {
            if (membro.MembroId == 0)
            {
                Membros.Add(membro);
            }
            else
            {
                Entry(membro).State = EntityState.Modified;
            }
            SaveChanges();
        }
    }
}