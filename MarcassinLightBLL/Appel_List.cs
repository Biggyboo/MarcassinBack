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
        public static List<Competence_BO> GetCompetencesActives()
        {
            
            List<Competence_BO> listCompBO = Competence_DAL.GetCompetence();
            List<Competence_BO> listCompBOAct = new List<Competence_BO>();
            foreach (Competence_BO comp in listCompBO)
            {
                if (comp.Est_active==true)
                {
                    listCompBOAct.Add(comp);
                }
            }
            return listCompBOAct;

        }

        public static List<Competence_BO> GetCompetencesArchives()
        {

            List<Competence_BO> listCompBO = Competence_DAL.GetCompetence();
            List<Competence_BO> listCompBOArc = new List<Competence_BO>();
            foreach (Competence_BO comp in listCompBO)
            {
                if (comp.Est_active == false)
                {
                    listCompBOArc.Add(comp);
                }
            }
            return listCompBOArc;

        }

        public static List<Categorie_BO> GetCategories()
        {
            List<Categorie_BO> listCatBO = Categorie_DAL.GetCategorie();

            return listCatBO;

        }

        public static List<Langue_BO> GetLangues()
        {
            List<Langue_BO> listLangBO = Langue_DAL.GetLangue();

            return listLangBO;

        }

        public static List<Badge_BO> GetBadges()
        {
            List<Badge_BO> listBadgBO = Badge_Dal.GetBadge();

            return listBadgBO;

        }

    }
}
