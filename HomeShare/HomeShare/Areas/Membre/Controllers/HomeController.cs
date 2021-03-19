using HomeShare.Infra;
using HomeShare.Models;
using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeShare.Areas.Membre.Controllers
{
    public class HomeController : Controller
    {
        private string[] valideImageType = { ".png", ".PNG", ".jpg", ".jpeg" };
        // GET: Membre/Home
        public ActionResult Index()
        {
            if (!SessionUtil.IsLogged) return RedirectToAction("Login", "Account", new { area = "" });

            return View(SessionUtil.ConnectedMembre);
        }

        public ActionResult FormBien()
        {
            ViewBag.Message = "Offres";
            return View(new BienModel());
        }


        [HttpPost]
        public ActionResult FormBien(BienModel bien, HttpPostedFileBase FilePicture)
        {


            if (ModelState.IsValid)
            {

                if (FilePicture.ContentLength > 0 && FilePicture.ContentLength < 200000000)
                {

                    //2 Vérifier le type
                    string extension = Path.GetExtension(FilePicture.FileName);
                    if (valideImageType.Contains(extension))
                    {

                        //1- DB
                        bien.Photo = FilePicture.FileName;

                        DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
                        if (ctx.SaveBien(bien))
                        {
                            //3 vérifier si le dossier de destination existe
                            //D:\Cours\Wad20\NetFlask\images\Users\1
                            string destFolder = Path.Combine(Server.MapPath("~/images/upload"), bien.IdBien.ToString());
                            if (!Directory.Exists(destFolder))
                            {
                                Directory.CreateDirectory(destFolder);
                            }

                            //4 - Upload de l'image
                            FilePicture.SaveAs(Path.Combine(destFolder, FilePicture.FileName));

                            //5 Mise à jour de l'objet User
                            SessionUtil.ConnectedBien = bien;


                            return RedirectToAction("About", "Home", new { area = "" });
                        }

                        else
                        {
                            ViewBag.ErrorMessage = "Bien non enregistré";
                            return View();
                        }

                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Bien non enregistré";
                        return View();
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Bien non enregistré";
                    return View();
                }


            }
            else
            {
                return View();
            }
        }

    }

}