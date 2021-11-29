using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Membros.Models;

namespace Eart.Persistencia.DAL
{
    public class MembroDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Membro> ObterMembrosClassificadosPorNome()
        {
            return context.Membros.OrderBy(m => m.Nome);
        }

        public Membro ObterMembroPorId(long id)
        {
            return context.Membros.Where(m => m.MembroId == id).First();
        }

        public Membro ObterMembroPorUsuario(string usuario)
        {
            return context.Membros.Where(m => m.Usuario == usuario).First();
        }

        public void GravarMembro(Membro membro)
        {
            if (membro.MembroId == 0)
            {
                context.Membros.Add(membro);
            }
            else
            {
                context.Entry(membro).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

    }
}