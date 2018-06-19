using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;

namespace MarcassinLightDAL
{
    public class LangueCategorie_DAL
    {
        public static List<LangueCategorie_BO> GetLangueCategories()
        {
            using (var context = new MarcassinEntities())
            {
                List<Categorie_Langue> listLangueCategorie = context.Categorie_Langue.ToList();
                List<LangueCategorie_BO> listLangueCategorieBO = listLangueCategorie.ToListLangueCategorieBO();
                return listLangueCategorieBO;
            }
        }
        public static List<LangueCategorie_BO> GetLangueCategoriesByIdCategorie(Categorie_BO Categorie)
        {
            using (var context = new MarcassinEntities())
            {
                var listLangueCategorie = from lanComp in context.Categorie_Langue
                                          where lanComp.Id_Categorie == Categorie.Id_Categorie
                                          select lanComp;

                List<LangueCategorie_BO> listLangueCategorieBO = new List<LangueCategorie_BO>();

                foreach(Categorie_Langue catLan in listLangueCategorie)
                {
                    var lan = from la in context.Langue
                              where la.id_Langue == catLan.id_Langue
                              select la.Langue_intitule;


                    var obj = new LangueCategorie_BO
                    {
                        Categorie = Categorie.Intitule,
                        Id_Categorie = Categorie.Id_Categorie,
                        Id_Langue = catLan.id_Langue,
                        Langue = lan.FirstOrDefault(),
                        Traduction = catLan.Traduction
                        
                    };
                    listLangueCategorieBO.Add(obj);
                }

                 return listLangueCategorieBO;
            }
        }

        public static void AddLangueCategories(LangueCategorie_BO langCatBO)
        {
            using (var db = new MarcassinEntities())
            {
                var catId = from ca in db.Categorie
                            where ca.Intitule == langCatBO.Categorie
                            select ca.id_Categorie;

                var LangId = from la in db.Langue
                             where la.Langue_intitule == langCatBO.Langue
                             select la.id_Langue;

                var langCompDb = from laC in db.Categorie_Langue
                                 where laC.id_Langue == langCatBO.Id_Langue & laC.Id_Categorie == langCatBO.Id_Categorie
                                 select laC.Id_Categorie;
                                 

                Categorie_Langue lanCat = new Categorie_Langue
                {
                    Id_Categorie = catId.FirstOrDefault(),
                    id_Langue = LangId.FirstOrDefault(),
                    Traduction = langCatBO.Traduction
                };
                
                // if traduction already exists
                if(langCompDb.Count() == 0)
                {
                    db.Categorie_Langue.Add(lanCat);
                }
                
                db.SaveChanges();
            }

        }

        public static void UpdLangueCategorie(LangueCategorie_BO lanCatBO)
        {

            using (var db = new MarcassinEntities())
            {
                
                var lanCat = from ca in db.Langue
                             where ca.Langue_intitule == lanCatBO.Langue
                             select ca.id_Langue;
                lanCatBO.Id_Langue = lanCat.FirstOrDefault();
                Categorie_Langue catLan = db.Categorie_Langue.Where(lc =>
                    lc.Id_Categorie == lanCatBO.Id_Categorie).Where(
                        l => l.id_Langue == lanCatBO.Id_Langue).FirstOrDefault();
               
                catLan.Traduction = lanCatBO.Traduction;
                db.SaveChanges();

            }
        }
    }
}
