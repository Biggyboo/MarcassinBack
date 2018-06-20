using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;

namespace MarcassinLightDAL
{
    public class LangueCompetence_DAL
    {
        public static Dictionary<string, string> GetTrad(Competence_BO compBO)
        {
            using (var db = new MarcassinEntities())
            {
                Dictionary<string, string> res = new Dictionary<string, string>();
                List<Langue_Competence> langcomp = db.Langue_Competence.Where(l => l.id_Competence == compBO.Id_Competence).ToList();
                foreach (var trad in langcomp)
                {
                    string lang = db.Langue.Find(trad.id_Langue).Langue_intitule.ToString();
                    string traduction = trad.Traduction.ToString();
                    res.Add(lang, traduction);
                }
                return res;
            }

        }

        public static void UpdTrad(string[] trad)
        {
            using (var db = new MarcassinEntities())
            {
                string intitulefr = trad[0];
                string intitulelang = trad[1];
                var req_id_comp = from lc in db.Langue_Competence
                                  where lc.Traduction == intitulefr
                                  select lc.id_Competence
                            ;
                int id_comp = req_id_comp.FirstOrDefault();


                Langue_Competence langcomp = db.Langue_Competence.Where(l => l.id_Competence == id_comp).Where(l => l.Langue.Langue_intitule == intitulelang).FirstOrDefault();
                langcomp.Traduction = trad[2];
                db.SaveChanges();
            }
        }

        public static void AddTrad(int id_comp, string lang, string trad)
        {
            using (var db = new MarcassinEntities())
            {
                db.Langue_Competence.Add( new Langue_Competence
                {
                    id_Competence = id_comp,
                    id_Langue = db.Langue.Where(l => l.Langue_intitule == lang).Select(l => l.id_Langue).FirstOrDefault(),
                    Traduction = trad
                });
                db.SaveChanges();
            }
        }
    }
}
