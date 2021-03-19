using HomeShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeShare.Infra
{
    public static class SessionUtil
    {
        public static bool IsLogged
        {
            get
            {

                if (HttpContext.Current.Session["logged"] == null)
                {
                    HttpContext.Current.Session["logged"] = false;
                }
                return (bool)HttpContext.Current.Session["logged"];
            }

            set { HttpContext.Current.Session["logged"] = value; }
        }



        public static MembreModel ConnectedMembre
        {
            get
            {
                return (MembreModel)HttpContext.Current.Session["ConnectedMembre"];
            }

            set { HttpContext.Current.Session["ConnectedMembre"] = value; }

        }


        public static BienModel ConnectedBien
        {
            get
            {
                return (BienModel)HttpContext.Current.Session["ConnectedBien"];
            }

            set { HttpContext.Current.Session["ConnectedBien"] = value; }

        }


    }
}


