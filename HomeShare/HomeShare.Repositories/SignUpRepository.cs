using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
    public class SignUpRepository : BaseRepository<SignUpEntity>, IConcreteRepository<SignUpEntity>
    {
        public SignUpRepository(string connectionString) : base(connectionString)
        {

        }
    
public bool Delete(SignUpEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<SignUpEntity> Get()
        {
            return base.Get("Select * from Membre");
        }

        public SignUpEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SignUpEntity toInsert)
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


        public bool Update(SignUpEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
