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
    
    public partial class Ugovor
    {
        public int Id { get; set; }
        public int Br_ugovora { get; set; }
        public System.DateTime Datum_sklapanja { get; set; }
        public System.DateTime Datum_Isteka { get; set; }
        public int SkladisteID { get; set; }
        public int PoslovnicaID { get; set; }
        public int KlijentID { get; set; }
        public int VoziloID { get; set; }
    
        public virtual Klijent Klijent { get; set; }
        public virtual Poslovnica Poslovnica { get; set; }
        public virtual Skladiste Skladiste { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}