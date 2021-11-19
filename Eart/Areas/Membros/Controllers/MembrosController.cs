using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eart.Areas.Membros.Models;
using Eart.Persistencia.DAL;

namespace Eart.Areas.Membros.Controllers
{
    public class MembrosController : Controller
    {
        MembroDAL membroDAL = new MembroDAL();
        private ActionResult GravarMembro(Membro membro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    membroDAL.GravarMembro(membro);
                    return RedirectToAction("Create");
                }
                return View(membro);
            }
            catch
            {
                return View(membro);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Membro membro)
        {
            return GravarMembro(membro);
        }
    }
}