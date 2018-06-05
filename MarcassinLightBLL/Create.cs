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
    }
}
