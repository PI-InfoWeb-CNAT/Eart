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

        public IQueryable<Membro> PesquisarMembros(string pesquisa)
        {
<<<<<<< HEAD
            return context.Membros.Where(u => (u.Usuario.ToUpper() == pesquisa.ToUpper()) || (u.Nome.ToUpper() == pesquisa.ToUpper()) && (u.Ativo == true));
=======
            return context.Membros.Where(u => (u.Usuario.ToUpper() == pesquisa.ToUpper()) || (u.Nome.ToUpper() == pesquisa.ToUpper()));
>>>>>>> main
        }

    }
}