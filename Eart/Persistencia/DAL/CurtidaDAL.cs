using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Comportamentos.Models;
using Eart.Areas.Membros.Models;
using Eart.Areas.Postagens.Models;

namespace Eart.Persistencia.DAL
{
    public class CurtidaDAL
    {
        private EFContext context = new EFContext();

        public Curtida ObterCurtidasClassificadasPorId()
        {
            return context.Curtidas.Include(m => m.Membro).OrderBy(p => p.PostagemId).First();
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

        public IList<Curtida> ObterCurtidasClassificadasPorMembro(long id)
        {
            return context.Curtidas.Where(m => m.MembroId == id).ToList();
        }

        public IList<Curtida> ObterCurtidasClassificadasPorPostagem(long id)
        {
            return context.Curtidas.Where(p => p.PostagemId == id).ToList();
        }

        public bool ObterPostagensCurtidasPorMembro(long idPostagem, long idMembro)
        {
            IQueryable<Curtida> curtidas = context.Curtidas.Where(p => p.PostagemId == idPostagem).Where(m => m.MembroId == idMembro);
            if (curtidas.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Curtida EliminarCurtidaPorId(long postagemid, long membroid)
        {
            Curtida curtida = context.Curtidas.Where(m => m.MembroId == membroid).Where(p => p.PostagemId == postagemid).First();
            context.Curtidas.Remove(curtida);
            context.SaveChanges();
            return curtida;
        }

        public void EliminarCurtida(Curtida curtida)
        {
            context.Curtidas.Remove(curtida);
            context.SaveChanges();
        }

    }
}