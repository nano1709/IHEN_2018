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
    
    public partial class CursoEstudiante
    {
        public string CodigoCurso { get; set; }
        public int CodigoEstudiante { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> Condicion { get; set; }
    
        public virtual Curso Curso { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }
}