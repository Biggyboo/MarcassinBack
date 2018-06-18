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
                
                if(langCompDb.Count() != 0)
                {
                    db.Categorie_Langue.Add(lanCat);
                }
                
                db.SaveChanges();
            }

        }
    }
}
