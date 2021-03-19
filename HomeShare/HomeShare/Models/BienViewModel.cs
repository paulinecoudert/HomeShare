using HomeShare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace HomeShare.Models
{
    public class BienViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<BienModel> _bienModels;
        public BienViewModel()
        {
            BienModels = ctx.GetCinqBien();
        }

        public List<BienModel> BienModels
        {
            get
            {
                return _bienModels;
            }

            set
            {
                _bienModels = value;
            }
        }
    }
}