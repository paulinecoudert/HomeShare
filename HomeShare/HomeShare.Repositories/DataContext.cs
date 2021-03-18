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
        IConcreteRepository<PaysEntity> _paysRepo;
        IConcreteRepository<MembreEntity> _membreRepo;



        public DataContext (string connectionString)
        {
            _bienRepo = new BienRepository(connectionString);
            _paysRepo = new PaysRepository(connectionString);
            _membreRepo = new MembreRepository(connectionString);



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
        public MembreModel UserAuth(LoginModel lm)
        {
            MembreEntity ue = ((MembreRepository)_membreRepo).GetFromLogin(lm.Login);
            if (ue == null) return null;
            if (ue != null)
            {
                return new MembreModel()
                {
                    IdMembre = ue.IdMembre,
                    Nom = ue.Nom,
                    Prenom = ue.Prenom,
                    Login = ue.Login,
                    Email = ue.Email,


                };
            }
            else
            {
                return null;
            }
        }



    }
}
