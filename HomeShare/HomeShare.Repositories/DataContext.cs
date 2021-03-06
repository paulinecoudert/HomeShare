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
        IConcreteRepository<MessageEntity> _messRepo;
        IConcreteRepository<BienEntity> _bienPaysRepo;
        IConcreteRepository<BienEntity> _bienDernierRepo;



        public DataContext (string connectionString)
        {
            _bienRepo = new BienRepository(connectionString);
            _bienPaysRepo = new BienPaysRepository(connectionString);
            _bienDernierRepo = new BienDernierRepository(connectionString);
            _paysRepo = new PaysRepository(connectionString);
            _membreRepo = new MembreRepository(connectionString);
            _messRepo = new MessageRepository(connectionString);




        }

    public List<BienModel> GetAllBien()
    {
            return _bienRepo.Get()
                .Select(m =>
               new BienModel()
               {
                   Titre = m.Titre,
                   DescCourte = m.DescCourte,
                   CodePostal = m.CodePostal,
                   Ville = m.Ville,
                   Pays = m.Pays,
                   NombrePerson= m.NombrePerson,
                   DescLong = m.DescLong,
                   Photo = m.Photo,

               }).ToList();

          
    }

        public List<BienModel> GetPaysBien()
        {
            return _bienPaysRepo.Get()
                .Select(m =>
               new BienModel()
               {
                   Titre = m.Titre,
                   DescCourte = m.DescCourte,
                   CodePostal = m.CodePostal,
                   Ville = m.Ville,
                   Pays = m.Pays,
                   NombrePerson = m.NombrePerson,
                   DescLong = m.DescLong,
                   Photo = m.Photo,

               }).ToList();


        }


        public List<BienModel> GetCinqBien()
        {
            return _bienRepo.Get()
                .Select(m =>
               new BienModel()
               {
                   Titre = m.Titre,
                   DescCourte = m.DescCourte,
                   CodePostal = m.CodePostal,
                   Ville = m.Ville,
                   Pays = m.Pays,
                   NombrePerson = m.NombrePerson,
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

        public bool SaveSignUp(SignUpModel sm)
        {
            MembreEntity signUp = new MembreEntity();
            //signUp.Rue = sm.Rue;
            //signUp.Numero = sm.Numero;
            //signUp.Ville = sm.Ville;
            //signUp.CodePostal = sm.CodePostal;
            signUp.Nom = sm.Nom;
            signUp.Prenom = sm.Prenom;
            signUp.Email = sm.Email;
            signUp.Pays = sm.Pays;
            signUp.Telephone = sm.Telephone;
            signUp.Login = sm.Login;
            signUp.Password = sm.Password;
            


            return _membreRepo.Insert(signUp);

        }



        public bool SaveContact(ContactModel cm)
        {
            //MAppers
            MessageEntity me = new MessageEntity();
            me.Nom = cm.Nom;
            me.Email = cm.Email;
            me.Telephone = cm.Telephone;
            me.Information = cm.Information;


            return _messRepo.Insert(me);
        }


        public bool SaveBien(BienModel bm)
        {
            //MAppers
            BienEntity be = new BienEntity();

            be.Titre = bm.Titre;
            be.DescCourte = bm.DescCourte;
            be.DescLong = bm.DescLong;
            be.Photo = bm.Photo;
            be.Pays = bm.Pays;
          




            //int idBien = 0;
            //bool test = ((BienRepository)_bienRepo).InsertWithId(be, out idBien);
            //if (test)
            //{
            //    bm.IdBien = idBien;

            //    return ((PaysRepository)_paysRepo).InsertFromProject(bm.Pays, idBien);
            //}
            //else
            //    return false;

            return _bienRepo.Insert(be);


        }




    }
}
