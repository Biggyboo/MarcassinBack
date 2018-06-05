using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightDAL;
using MarcassinLightBO;

namespace MarcassinLightBLL
{
    public class Appel_List
    {
        public static List<Competence_BO> GetCompetences()
        {
            List<Competence_BO> listCompBO = Competence_DAL.GetCompetence();

            return listCompBO;

        }

        public static List<Categorie_BO> GetCategories()
        {
            List<Categorie_BO> listCompBO = Categorie_DAL.GetCategorie();

            return listCompBO;

        }
    }
}
