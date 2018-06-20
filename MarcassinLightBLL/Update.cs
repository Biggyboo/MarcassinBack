using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightDAL;
using MarcassinLightBO;

namespace MarcassinLightBLL
{
    public class Update
    {
        public static void UpdateCompetence(Competence_BO compBO)
        {
            Competence_DAL.UpdCompetence(compBO);
        }
        public static void UpdateLangueCategorie(LangueCategorie_BO lanCat)
        {
            LangueCategorie_DAL.UpdLangueCategorie(lanCat);
        }

        public static void UpdateTrad(string[] trad)
        {
            LangueCompetence_DAL.UpdTrad(trad);
        }

        public static void UpdateCategorie(Categorie_BO cat)
        {
            Categorie_DAL.UpdCategorie(cat);
        }
        public static void UpdateBadge(Badge_BO badBO)
        {
            Badge_DAL.UpdBadge(badBO);
        }
        public static void UpdateBadgeTrad(Langue_Badge_BO lanBad)
        {
            Langue_Badge_DAL.UpdLangueBadge(lanBad);
        }
    }
}
