using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;

namespace MarcassinLightDAL
{
    public class Langue_Badge_DAL
    {
        public static List<Langue_Badge_BO> GetTraductionBadge()
        {
            using (var context = new MarcassinEntities())
            {
                List<Langue_Badge> listLangueBadge = context.Langue_Badge.ToList();
                List<Langue_Badge_BO> listLangueBadgeBO = listLangueBadge.ToListLangueBadgeBO();

                return listLangueBadgeBO;
            }
        }

        public static List<Langue_Badge_BO> GetTraductionByBadge(Badge_BO bad)
        {
            List<Langue_Badge_BO> bla = new List<Langue_Badge_BO>();
            using (var db = new MarcassinEntities())
            {
                var trad = from tra in db.Langue_Badge
                           where tra.id_Badge == bad.Id_Badge
                           join lan in db.Langue on tra.id_Langue equals lan.id_Langue
                           select tra;
                foreach(var item in trad)
                {
                    bla.Add(new Langue_Badge_BO
                    {
                        Traduction = item.Traduction,
                        Langue = item.Langue.Langue_intitule,
                        Badge = item.id_Badge
                    });

                }
            }
            return bla;
        }
        public static void UpdLangueBadge(Langue_Badge_BO lanBad)
        {
            using (var db = new MarcassinEntities())
            {
                int id_langue = db.Langue.Where(l => l.Langue_intitule == lanBad.Langue).Select(l => l.id_Langue).FirstOrDefault(); 
                Langue_Badge laBa = db.Langue_Badge.Where(lb =>
                lb.id_Langue == id_langue).Where(lb => lb.id_Badge == lanBad.Badge)
                .FirstOrDefault();

                laBa.Traduction = lanBad.Traduction;
                db.SaveChanges();
            }
        }
    }
}
