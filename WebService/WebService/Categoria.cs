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
    
    public partial class Categoria
    {
        public Categoria()
        {
            this.Producte = new HashSet<Producte>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public Nullable<double> Descompte { get; set; }
    
        public virtual ICollection<Producte> Producte { get; set; }
    }
}