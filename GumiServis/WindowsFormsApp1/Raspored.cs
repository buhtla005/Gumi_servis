//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raspored
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raspored()
        {
            this.Radni_nalog = new HashSet<Radni_nalog>();
        }
    
        public int Id { get; set; }
        public int BoksId { get; set; }
        public int VoziloId { get; set; }
        public System.DateTime DatumVrijeme { get; set; }
    
        public virtual Bok Bok { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radni_nalog> Radni_nalog { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
