using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    class MembreRepository : BaseRepository<MembreEntity>, IConcreteRepository<MembreEntity>
    {

        public MembreRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(MembreEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<MembreEntity> Get()
        {
            return base.Get("Select * from Membre");
        }

        public MembreEntity GetOne(int PK)
        {
            return base.GetOne(PK, "Select * from Membre where IdMembre=@id");
        }

        public MembreEntity GetFromLogin(string login)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("login", login);
            return base.Get("Select * from [Membre] where Login=@login", p).FirstOrDefault();
        }

        public bool Insert(MembreEntity toInsert)
        {
            string requete = @"INSERT INTO [dbo].[Membre]
          ([Nom]
           ,[Prenom]
           ,[Email]
           ,[Pays]
           ,[Telephone]
           ,[Login]
           ,[Password])
            VALUES
           (@Nom
           ,@Prenom
           ,@Email 
           ,@Pays
           ,@Telephone
            ,@Login
            ,@Password)";

            return base.Insert(toInsert, requete);
        }
    

        public bool Update(MembreEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
