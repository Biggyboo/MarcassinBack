using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarcassinLightBO;

namespace MarcassinLightDAL
{
    public class Badge_DAL
    {
        public static List<Badge_BO> GetBadge()
        {
            using (var context = new MarcassinEntities())
            {
                List<Badge> listBadges = context.Badge.ToList();
                List<Badge_BO> listBadgesBO = listBadges.ToListBadgeBO();

                return listBadgesBO;
            }
        }
        public static void AddBadge(Badge_BO badgBO)
        {
            using (var db = new MarcassinEntities())
            {
                db.Badge.Add(new Badge
                {
                    nom=badgBO.Intitule
                });
                db.SaveChanges();
            }
        }

        public static void UpdBadge(Badge_BO badBO)
        {

            using (var db = new MarcassinEntities())
            {
                Badge badg = db.Badge.Where(b => b.id_Badge == badBO.Id_Badge).FirstOrDefault();
                badg.nom = badBO.Intitule;
                db.SaveChanges();
                Langue_Badge lanbad = db.Langue_Badge.Where(lb => lb.id_Badge == badBO.Id_Badge)
                    .Where(lb => lb.Traduction == badBO.Intitule).Where(lb => lb.id_Langue == 1).FirstOrDefault();
                db.SaveChanges();
            }
        }

    }
}
