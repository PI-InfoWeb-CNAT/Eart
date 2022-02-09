﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eart.Persistencia.Contexts;
using System.Data.Entity;
using Eart.Areas.Comportamentos.Models;

namespace Eart.Persistencia.DAL
{
    public class ComentarioDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<Comentario> ObterComentariosClassificadosPorId()
        {
            return context.Comentarios.Include(m => m.Membro).Include(p => p.Postagem).OrderBy(c => c.ComentarioId);
        }

        public Comentario ObterComentarioPorId(long id)
        {
            return context.Comentarios.Where(c => c.ComentarioId == id).Include(m => m.Membro).First();
        }

        public void GravarComentario(Comentario comentario)
        {
            if (comentario.ComentarioId is null)
            {
                context.Comentarios.Add(comentario);
            }
            else
            {
                context.Entry(comentario).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public Comentario EliminarComentarioPorId(long id)
        {
            Comentario comentario = ObterComentarioPorId(id);
            context.Comentarios.Remove(comentario);
            context.SaveChanges();
            return comentario;
        }

    }
}