//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Essaie.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        public int idproduit { get; set; }
        public string Designation { get; set; }
        public Nullable<double> QteStock { get; set; }
        public Nullable<double> QteMin { get; set; }
        public Nullable<System.DateTime> DatePeremption { get; set; }
    }
}
