//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class War
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public War()
        {
            this.Battles = new HashSet<Battle>();
            this.CountryInWars = new HashSet<CountryInWar>();
            this.WarEvents = new HashSet<WarEvent>();
        }
    
        public int ID { get; set; }
        public int StartDay { get; set; }
        public Nullable<int> EndDay { get; set; }
        public int AttackerCountryID { get; set; }
        public int DefenderCountryID { get; set; }
        public bool Active { get; set; }
        public Nullable<bool> AttackerOfferedSurrender { get; set; }
        public bool IsRessistanceWar { get; set; }
        public Nullable<int> RessistanceStarterID { get; set; }
        public bool IsTrainingWar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Battle> Battles { get; set; }
        public virtual Country Attacker { get; set; }
        public virtual Country Defender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CountryInWar> CountryInWars { get; set; }
        public virtual Citizen Citizen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarEvent> WarEvents { get; set; }
    }
}