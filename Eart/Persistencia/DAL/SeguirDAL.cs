using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Comportamentos.Models;

namespace Eart.Persistencia.DAL
{
    public class SeguirDAL
    {
        private EFContext context = new EFContext();

        public Seguir ObterSeguirPorId(long id)
        {
            return context.Seguindo.Where(m => m.SeguirId == id).First();
        }

        public bool ObterMembroSeguido(long idMembroLogado, long idMembroSeguido)
        {
            IQueryable<Seguir> seguindo = context.Seguindo.Where(ml => ml.Seguindo.MembroId == idMembroLogado).Where(ms => ms.Seguidor.MembroId == idMembroSeguido);
            if (seguindo.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void GravarSeguir(Seguir seguir)
        {
            if (seguir.SeguirId is null)
            {
                context.Seguindo.Add(seguir);
            }
            else
            {
                context.Entry(seguir).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Seguir EliminarSeguirPorId(long id)
        {
            Seguir seguir = ObterSeguirPorId(id);
            context.Seguindo.Remove(seguir);
            context.SaveChanges();
            return seguir;
        }
    }
}