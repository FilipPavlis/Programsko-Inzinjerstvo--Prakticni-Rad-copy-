//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ObavijestiService
{
    using System;
    using System.Collections.Generic;
    
    public partial class evidencija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public evidencija()
        {
            this.se_nalazi = new HashSet<se_nalazi>();
        }
    
        public int evidencija_id { get; set; }
        public int grupa_id { get; set; }
        public System.DateTime vrijeme_dolaska { get; set; }
        public Nullable<System.DateTime> vrijeme_odlaska { get; set; }
    
        public virtual grupa grupa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<se_nalazi> se_nalazi { get; set; }
    }
}
