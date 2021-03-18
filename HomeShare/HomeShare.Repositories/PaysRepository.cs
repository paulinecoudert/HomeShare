using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class PaysRepository : BaseRepository<PaysEntity>, IConcreteRepository<PaysEntity>
    {

        public PaysRepository(string connectionString) : base(connectionString)
        {

        }
        public bool Delete(PaysEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<PaysEntity> Get()
        {
            throw new NotImplementedException();
        }

        public PaysEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public List<PaysEntity> GetFromBien ()
        {
            string requete = @"SELECT dbo.Pays.Libelle, dbo.BienEchange.Pays
              FROM   dbo.BienEchange INNER JOIN
             dbo.Pays ON dbo.BienEchange.Pays = dbo.Pays.idPays";
            return base.Get(requete);
        }



        public bool Update(PaysEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PaysEntity toInsert)
        {
            throw new NotImplementedException();
        }
    }
}
