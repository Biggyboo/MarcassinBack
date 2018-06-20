using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MarcassinLightBO
{
    public class Langue_Badge_BO
    {
        public int Id_Langue { get; set; }
        public string Langue { get; set; }

        public int Badge { get; set; }
        
        public string Traduction { get; set; }

    }
}