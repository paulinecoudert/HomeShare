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
        private List<BienModel> _bienToutModels;
        private List<BienModel> _bienCinqModels;

        public BienViewModel()
        {
            BienModels = ctx.GetPaysBien();
            BienToutModels = ctx.GetAllBien();
            BienCinqModels = ctx.GetCinqBien();
            
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

        public List<BienModel> BienToutModels
        {
            get
            {
                return _bienToutModels;
            }

            set
            {
                _bienToutModels = value;
            }
        }

        public List<BienModel> BienCinqModels
        {
            get
            {
                return _bienCinqModels;
            }

            set
            {
                _bienCinqModels = value;
            }
        }
    }
}