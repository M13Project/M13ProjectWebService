//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comanda_Producte
    {
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public int ProducteId { get; set; }
        public int Quantitat { get; set; }
        public int ComercialId { get; set; }
    
        public virtual Comanda Comanda { get; set; }
        public virtual Producte Producte { get; set; }
    }
}
