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
    
    public partial class Zaposlenik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
        public Nullable<int> PoslovnicaID { get; set; }
    
        public virtual Poslovnica Poslovnica { get; set; }
    }
}
