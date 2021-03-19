﻿using HomeShare.DAL.Repositories;
using HomeShare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeShare.Repositories
{
   public class BienRepository : BaseRepository<BienEntity>, IConcreteRepository<BienEntity>
    {
        public BienRepository(string cnstr) : base(cnstr)
        {

        }

        public bool Delete(BienEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<BienEntity> Get()
        {
            string requete = "Select * from Vue_CinqDernierBiens ";

            return base.Get(requete);
        }





        public BienEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        //public bool Insert(BienEntity toInsert)
        //{
        //    throw new NotImplementedException();
        //}

        public bool Insert(BienEntity toInsert) 
        {
            string requete = @"INSERT INTO[dbo].[BienEchange]
            (titre
           ,DescCourte
           ,DescLong
           ,NombrePerson
           ,Pays
           ,Ville
           ,Rue
           ,Numero
           ,CodePostal
           ,Photo
           ,AssuranceObligatoire
           ,isEnabled
           ,DisabledDate
           ,Latitude
           ,Longitude
           ,idMembre
           ,DateCreation)
     VALUES
           (@titre
           ,@DescCourte
           ,@DescLong
           @NombrePerson
           ,@Pays
           ,@Ville
           ,@Rue
           ,@Numero
           ,@CodePostal
           ,@Photo
           ,@AssuranceObligatoire
           ,@isEnabled
           ,@DisabledDate
           ,@Latitude
           ,@Longitude
           ,@idMembre
           ,@DateCreation)";


            return base.Insert(toInsert, requete);
        }

        public bool Update(BienEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
