using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using HomeShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
   public class DataContext
    {
        IConcreteRepository<BienEntity> _bienRepo;
        IConcreteRepository<BienEntity> _paysRepo;



        public DataContext (string connectionString)
    {
        _bienRepo = new BienRepository(connectionString);
    }

    public List<BienModel> GetCinqBien()
    {
            return _bienRepo.Get()
                .Select(m =>
               new BienModel()
               {
                   DescCourte = m.DescCourte,
                   CodePostal = m.CodePostal,
                   Ville = m.Ville,
                   DescLong = m.DescLong,
                   Photo = m.Photo,

               }).ToList();

          
    }




    }
}
