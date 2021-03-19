using HomeShare.Models;
using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeShare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Home = "active";
            HomeViewModel hm = new HomeViewModel();
            Session["messageInfo"] = "ceci est un mesage";
            Session.Abandon();
            return View(hm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
           BienViewModel hm = new BienViewModel();
            return View(hm);
        }

        public ActionResult Pays()
        {
            ViewBag.Message = " ";
            BienViewModel hm = new BienViewModel();
            return View(hm);
        }


        public ActionResult DernierBien()
        {
            ViewBag.Message = " ";
            BienViewModel hm = new BienViewModel();
            return View(hm);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

                if (ctx.SaveContact(contact))
                {
                    ViewBag.SuccessMessage = "Message bien envoyé";
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Message non enregistré";
                    return View();
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Formulaire error";
                return View();
            }

        }
    }
}