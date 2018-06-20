using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;

namespace MarcassinLightDAL
{
    public class Competence_DAL
    {
        public static List<Competence_BO> GetCompetence()
        {
            using (var context = new MarcassinEntities())
            {
                List<Competence> listCompetences = context.Competence.ToList();
                List<Competence_BO> listCompetencesBO = listCompetences.ToListCompetenceBO();

                return listCompetencesBO;
            }
        }

        public static void AddCompetence(Competence_BO compBO)
        {
            using (var db = new MarcassinEntities())
            {
                var cat = from ca in db.Categorie
                          where ca.Intitule == compBO.Categorie
                          select ca.id_Categorie;
                Competence comp = new Competence
                {
                    id_categorie = cat.FirstOrDefault(),
                    est_actif = true
                };
                db.Competence.Add(comp);
                db.SaveChanges();
                db.Langue_Competence.Add(new Langue_Competence
                {
                    id_Competence = comp.id_Competence,
                    Traduction = compBO.Competence,
                    id_Langue = 1,
                });
                db.SaveChanges();

            }

        }

        public static void UpdCompetence(Competence_BO compBO)
        {


            using (var db = new MarcassinEntities())
            {

                Competence comp = db.Competence.Find(compBO.Id_Competence);

                var cat = from ca in db.Categorie
                          where ca.Intitule == compBO.Categorie
                          select ca.id_Categorie;
                comp.id_categorie = cat.FirstOrDefault();
                db.SaveChanges();

                if (compBO.Competence_mere != "")
                {
                    var comref = from lc in db.Langue_Competence
                                 where lc.Traduction == compBO.Competence_mere
                                 select lc.id_Competence;

                    comp.id_Competence_ref = comref.FirstOrDefault();
                    comp.est_actif = false;
                }
                db.SaveChanges();

                Langue_Competence langcomp = db.Langue_Competence.Where(l => l.id_Competence == compBO.Id_Competence).Where(l => l.id_Langue == 1).FirstOrDefault();
                langcomp.Traduction = compBO.Competence;
                db.SaveChanges();

            }
        }


    }
}
