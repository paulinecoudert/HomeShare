using HomeShare.Infra;
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

 public class AccountController : Controller
{
    DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
    // GET: Acount


    public ActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ActionResult Logout()
    {
        Session.Abandon();

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public ActionResult Login()
    {
        return View(new LoginModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginModel lm)
    {
        if (ModelState.IsValid)
        {
            MembreModel um = ctx.UserAuth(lm);
            if (um == null)
            {
                ViewBag.Error = "Erreur Login/Password";
                return View();
            }
            else
            {
                SessionUtil.IsLogged = true;
                SessionUtil.ConnectedMembre = um;
                return RedirectToAction("Index", "Home", new { area = " " });
            }
        }
        else
        {
            return View();
        }

    }
  


}
}