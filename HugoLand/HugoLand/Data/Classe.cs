//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HugoLand.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Classe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classe()
        {
            this.Heros = new HashSet<Hero>();
        }
    
        public int Id { get; set; }
        public string NomClasse { get; set; }
        public string Description { get; set; }
        public int StatBaseStr { get; set; }
        public int StatBaseDex { get; set; }
        public int StatBaseInt { get; set; }
        public int StatBaseVitalite { get; set; }
        public int MondeId { get; set; }
    
        public virtual Monde Monde { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hero> Heros { get; set; }
    }
}
