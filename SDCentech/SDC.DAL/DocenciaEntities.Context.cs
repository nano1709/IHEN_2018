﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DocenciaEntities : DbContext
    {
        public DocenciaEntities()
            : base("name=DocenciaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Estudiante> Estudiantes { get; set; }
        public virtual DbSet<Modulo> Moduloes { get; set; }
        public virtual DbSet<ModuloProfesor> ModuloProfesors { get; set; }
        public virtual DbSet<Profesor> Profesors { get; set; }
        public virtual DbSet<Tecnico> Tecnicoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<CursoEstudiante> CursoEstudiantes { get; set; }
        public virtual DbSet<ModuloEstudiante> ModuloEstudiantes { get; set; }
        public virtual DbSet<TecnicoEstudiante> TecnicoEstudiantes { get; set; }
        public virtual DbSet<Sede> Sedes { get; set; }
        public virtual DbSet<evento> eventos { get; set; }
    }
}
