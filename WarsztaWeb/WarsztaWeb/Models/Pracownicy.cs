//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarsztaWeb.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    public partial class Pracownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pracownicy()
        {
            this.Uslugi = new HashSet<Uslugi>();
        }
    
        public int id_Pracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string nrTelefonu { get; set; }
        [JsonIgnore]
        public  Uzytkownicy Uzytkownicy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public  ICollection<Uslugi> Uslugi { get; set; }
    }
}
