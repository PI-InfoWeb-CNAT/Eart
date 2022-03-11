using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Postagens.Models;

namespace Eart.Persistencia.DAL
{
    public class PostagemDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Postagem> ObterPostagensClassificadasPorId()
        {
            return context.Postagens.Include(m => m.Membro).OrderBy(p => p.PostagemId);
        }

        public IQueryable<Postagem> ObterPostagensClassificadasPorData()
        {
            return context.Postagens.Include(m => m.Membro).OrderByDescending(p => p.Data);
        }

        public IQueryable<Postagem> ObterPostagensClassificadasPorMembro(long id)
        {
            return context.Postagens.Where(m => m.MembroId == id);
        }

        public Postagem ObterPostagemPorId(long id)
        {
            return context.Postagens.Where(p => p.PostagemId == id).Include(m => m.Membro).First();
        }

        public void GravarPostagem(Postagem postagem)
        {
            if (postagem.PostagemId is null)
            {
                context.Postagens.Add(postagem);
            }
            else
            {
                context.Entry(postagem).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Postagem EliminarPostagemPorId(long id)
        {
            Postagem postagem = ObterPostagemPorId(id);
            context.Postagens.Remove(postagem);
            context.SaveChanges();
            return postagem;
        }

        public void EliminarPostagem(Postagem postagem)
        {
            context.Postagens.Remove(postagem);
            context.SaveChanges();
        }

    }
}