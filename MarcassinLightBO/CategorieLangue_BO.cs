using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcassinLightBO
{
    public class CategorieLangue_BO
    {
        public int Id_Categorie { get; set; }
        public int id_Langue{ get; set; }
        public string Langue { get; set; }
        public string Categorie { get; set; }
        public string Traduction { get; set; }
        public override string ToString()
        {
            return this.Traduction;
        }
    }
}
