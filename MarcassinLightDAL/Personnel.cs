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
    
    public partial class Personnel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personnel()
        {
            this.Participant = new HashSet<Participant>();
        }
    
        public int id_Utilisateur { get; set; }
        public System.DateTime Date_deb_contrat { get; set; }
        public Nullable<System.DateTime> Date_fin_contrat { get; set; }
        public bool Est_admin { get; set; }
        public Nullable<int> id_service { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participant { get; set; }
        public virtual Service Service { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}