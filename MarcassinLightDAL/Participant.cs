//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarcassinLightDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participant
    {
        public int id_Utilisateur { get; set; }
        public int id_Cours { get; set; }
        public bool est_orga { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Personnel Personnel { get; set; }
    }
}
