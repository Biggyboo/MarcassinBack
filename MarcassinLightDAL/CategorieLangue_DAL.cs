using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;

namespace MarcassinLightDAL
{
    public class CategorieLangue_DAL
    {
        public static List<CategorieLangue_BO> GetCategorieLangue()
        {
            using (var context = new MarcassinEntities())
            {
                List<Categorie_Langue> listCategoriesLangues = context.Categorie_Langue.ToList();
                List<CategorieLangue_BO> listCategoriesLanguesBO = listCategoriesLangues.ToListCategorieLangueBO();

                return listCategoriesLanguesBO;
            }
        }
        /// <summary>
        /// Adds a categorie in database
        /// Simon-HUET
        /// </summary>
        /// <param name="catLanBO">Categorie langue to add</param>
        public static void AddCategorieLangue(CategorieLangue_BO catLanBO)
        {

            using (var db = new MarcassinEntities())
            {
                var catLan = new Categorie_Langue
                {
                    Id_Categorie = catLanBO.Id_Categorie,
                    id_Langue = catLanBO.id_Langue,
                    Traduction = catLanBO.Traduction

                };

                db.Categorie_Langue.Add(catLan);
                db.SaveChanges();
               
            }

        }
    }
}

