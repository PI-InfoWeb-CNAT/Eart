using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Postagens.Models;
using Eart.Areas.Membros.Models;

namespace Eart.Persistencia.DAL
{
    public class PesquisaDAL
    {
        EFContext context = new EFContext();

        public IQueryable<Postagem> PesquisarPostagensPorConteudo(string texto)
        {
            return context.Postagens.Include(t => t.Texto.Contains(texto));
        }

        public IQueryable<Membro> PesquisarMembros(string pesquisa)
        {
            return context.Membros.Where(u => (u.Usuario == pesquisa) || (u.Nome == pesquisa));
        }

    }
}