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
    public class CurtidaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Curtida> ObterCurtidasClassificadasPorId()
        {
            return context.Curtidas.Include(m => m.Membro).OrderBy(p => p.PostagemId);
        }
        public void GravarCurtida(Curtida curtida)
        {
            if (curtida.CurtidaId is null)
            {
                context.Curtidas.Add(curtida);
            }
            else
            {
                context.Entry(curtida).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Curtida ObterCurtidaPorId(long id)
        {
            return context.Curtidas.Where(c => c.CurtidaId == id).First();
        }

        public Curtida EliminarCurtidaPorId(long id)
        {
            Curtida curtida = ObterCurtidaPorId(id);
            context.Curtidas.Remove(curtida);
            context.SaveChanges();
            return curtida;
        }
    }
}