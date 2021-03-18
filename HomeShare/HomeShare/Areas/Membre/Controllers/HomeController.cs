using HomeShare.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeShare.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {

        // GET: Membre/Home
        public ActionResult Index()
        {
            if (!SessionUtil.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View(SessionUtil.ConnectedMembre);
        }
    }
}