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
        public void GravarMembro(Membro membro)
        {
            if (membro.Id == null || membro.Id == 0)
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