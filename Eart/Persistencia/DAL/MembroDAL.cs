using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Membros.Models;
using Eart.Areas.Comportamentos.Models;

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
            IQueryable<Membro> membros = context.Membros.Where(u => u.Usuario == usuario).Where(m => m.Ativo == true);

            if (membros.Count() != 0)
            {
                return membros.First();
            }
            else
            {
                return null;
            }
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


        public void GravarMembro(Membro membro)
        {
            if (membro.MembroId is null)
            {
                context.Membros.Add(membro);
            }
            else
            {
                context.Entry(membro).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Membro EliminarMembroPorId(long id)
        {
            Membro membro = ObterMembroPorId(id);
            context.Membros.Remove(membro);
            context.SaveChanges();
            return membro;
        }

    }
}