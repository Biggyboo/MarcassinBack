using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;
using MarcassinLightDAL;

namespace MarcassinLightBLL
{
    public class Create
    {
        public static void CreateCompetence(Competence_BO compBO)
        {
            Competence_DAL.AddCompetence(compBO);
        }
        public static void CreateLangue(Langue_BO langBO)
        {
            Langue_DAL.AddLangue(langBO);
        }
        public static void CreateBadge(Badge_BO badgBO)
        {
            Badge_DAL.AddBadge(badgBO);
        }
        public static void CreateCategorie(Categorie_BO catBO)
        {
            Categorie_DAL.AddCategorie(catBO);
        }
        public static void CreateLangueCategorie(LangueCategorie_BO langCatBO)
        {
            LangueCategorie_DAL.AddLangueCategories(langCatBO);
        }
        public static void CreateLangueCompetence(int id_comp, string langue, string trad)
        {
            LangueCompetence_DAL.AddTrad(id_comp,langue,trad);
        }

    }
}
