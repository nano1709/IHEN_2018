//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDC.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tecnico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tecnico()
        {
            this.TecnicoEstudiantes = new HashSet<TecnicoEstudiante>();
        }
    
        public string CodigoTecnico { get; set; }
        public string NombreTecnico { get; set; }
        public string PerfilOcupacional { get; set; }
        public string Duracion { get; set; }
        public string PracticaProf { get; set; }
        public string Requisitos { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<int> IdSede { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TecnicoEstudiante> TecnicoEstudiantes { get; set; }
    }
}