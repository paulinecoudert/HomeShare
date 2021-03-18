using System.Web;
using System.Web.Optimization;

namespace HomeShare
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/Css").Include(
                "~/Css/bootstrap.css",
                "~/Css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-1.9.1.min.js",
                 "~/js/bootstrap.js",
                      "~/js/script.js"));

            bundles.Add(new StyleBundle("~/Content/Css1").Include(
             "~/Css/owl.carousel.css",
                     "~/Css/owl.theme.css"
         ));

            bundles.Add(new ScriptBundle("~/bundles/scripts1").Include(
                            "~/js/owl.carousel.js"
                 ));





            bundles.Add(new StyleBundle("~/Content/Css2").Include(
            "~/Css/Slitcss/style.css",
                     "~/Css/Slitcss/custom.css"
             
                ));



            bundles.Add(new ScriptBundle("~/bundles/scripts2").Include(
            
              
                "~/js/modernizr.custom.79639.js",
                "~/js/jquery.ba-cond.min.js",
                "~/js/jquery.slitslider.js"
                  
                 ));


                
        }
    }
}
