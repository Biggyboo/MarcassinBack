using MarcassinLightBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcassinLightDAL
{
    public static class Extension
    {
        public static List<Competence_BO> ToListCompetenceBO(this List<Competence> list)
        {
            if (list == null)
            {
                return null;
            }
            List<Competence_BO> listCompetenceBO = new List<Competence_BO>();
            foreach (Competence cpt in list)
            {
                using (var db = new MarcassinEntities())
                {
                    var comp = from lc in db.Langue_Competence
                               where lc.id_Competence == cpt.id_Competence && lc.id_Langue == 1
                               select lc.Traduction;
                    var compm = from lc in db.Langue_Competence
                                where lc.id_Competence == cpt.id_Competence_ref && lc.id_Langue == 1
                                select lc.Traduction;
                    var compme = "";
                    if (compm != null)
                    {
                        compme = compm.FirstOrDefault();
                    }


                    var bo = new Competence_BO
                    {
                        Id_Competence = cpt.id_Competence,
                        Id_Categorie = cpt.id_categorie,
                        Id_Competence_mere = cpt.id_Competence_ref,
                        Competence = comp.First(),
                        Categorie = cpt.Categorie.Intitule,
                        Competence_mere = compme,
                        Est_active = cpt.est_actif

                    };
                    listCompetenceBO.Add(bo);
                }
            }
            return listCompetenceBO;
        }


        public static List<Categorie_BO> ToListCategorieBO(this List<Categorie> list)
        {
            if (list == null)
            {
                return null;
            }
            List<Categorie_BO> listCategorieBO = new List<Categorie_BO>();
            foreach (Categorie cat in list)
            {
                using (var db = new MarcassinEntities())
                {
                    var bo = new Categorie_BO
                    {
                        Id_Categorie=cat.id_Categorie,
                        Id_Categorie_mere=cat.id_Categorie_Mere,
                        Intitule=cat.Intitule
                    };
                    listCategorieBO.Add(bo);
                }
            }
            return listCategorieBO;
        }
    }
}




