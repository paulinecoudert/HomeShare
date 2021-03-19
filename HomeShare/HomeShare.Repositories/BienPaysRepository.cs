using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class BienPaysRepository : BaseRepository<BienEntity>, IConcreteRepository<BienEntity>
    {
        public BienPaysRepository(string cnstr) : base(cnstr)
        {

        }
    
public bool Delete(BienEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<BienEntity> Get()
        {
            string requete = @"SELECT     TOP (100) PERCENT idBien, titre, DescCourte, DescLong, NombrePerson, Pays, Ville, Rue, Numero, CodePostal, Photo, AssuranceObligatoire, isEnabled, DisabledDate, Latitude, Longitude, 
                      idMembre, DateCreation
                        FROM         dbo.BienEchange
                            ORDER BY Pays";

            return base.Get(requete);
        }

        public BienEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BienEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(BienEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
