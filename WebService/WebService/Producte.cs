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
    
    public partial class Producte
    {
        public Producte()
        {
            this.Comanda_Producte = new HashSet<Comanda_Producte>();
        }
    
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Preu { get; set; }
        public Nullable<double> Descompte { get; set; }
        public string Imatge { get; set; }
        public bool Habilitat { get; set; }
        public int CategoriaId { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Comanda_Producte> Comanda_Producte { get; set; }
    }
}
