using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SDC.DAL.Metodos
{
    public class MCurso : MDB, ICurso
    {

        DocenciaEntities sc = new DocenciaEntities();


        private static MCurso instancia;

        public static MCurso Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MCurso();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }


        public void ActualizarCurso(DATA.Curso curso)
        {
            DAL.Curso registroCur = new DAL.Curso();
            DATA.Curso listaCedulaCru = new DATA.Curso();

            try
            {
                sc.Database.Connection.Open();
                var actCur = sc.Cursoes.Where(x => x.CodigoCurso == curso.CodigoCurso).First();
                actCur.Certificacion = curso.Certificacion;
                actCur.Duracion = curso.Duracion;
                actCur.Estado = curso.Estado;
                actCur.Inversion = curso.Inversion;
                actCur.MaterialDidactico = curso.MaterialDidactico;
                actCur.Metodologia = curso.Metodologia;
                actCur.CodigoCurso = curso.CodigoCurso;
                actCur.NombreCurso = curso.NombreCurso;
                actCur.ObjetivoCurso = curso.ObjetivoCurso;
                actCur.IdSede = curso.IdSede;


                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void EliminarCursp(DATA.Curso curso)
        {
            DAL.Curso registroCur = new DAL.Curso();
            DATA.Curso listaCedulaCru = new DATA.Curso();

            try
            {
                sc.Database.Connection.Open();
                var actCur = sc.Cursoes.Where(x => x.CodigoCurso == curso.CodigoCurso).First();
                actCur.Estado = false;

                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }
        }

        public List<Curso> ListaCurso()
        {
            List<DAL.Curso> lista = new List<Curso>();
            try
            {
                sc.Database.Connection.Open();
                lista = sc.Cursoes.ToList();

                sc.Database.Connection.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }

        public void RegistroCurso(DATA.Curso curso)
        {
            DAL.Curso registroCur = new DAL.Curso();
            DATA.Curso listaCedulaCru = new DATA.Curso();

            try
            {
                sc.Database.Connection.Open();


                registroCur.Certificacion = curso.Certificacion;
                registroCur.CodigoCurso = curso.CodigoCurso;
                registroCur.Duracion = curso.Duracion;
                registroCur.Estado = curso.Estado;
                registroCur.Inversion = curso.Inversion;
                registroCur.MaterialDidactico = curso.MaterialDidactico;
                registroCur.Metodologia = curso.Metodologia;
                registroCur.ObjetivoCurso = curso.ObjetivoCurso;
                registroCur.NombreCurso = curso.NombreCurso;
                registroCur.IdSede = curso.IdSede;

                sc.Cursoes.Add(registroCur);
                sc.SaveChanges();
                sc.Database.Connection.Close();


            }
            catch (Exception)
            {

                throw;
            }

        }

        public DATA.Curso SeleccionarCursoId(String Id)
        {
            DAL.Curso registroCur = new DAL.Curso();
            DATA.Curso DatCurso = new DATA.Curso();


            try
            {
                sc.Database.Connection.Open();
                var curso = sc.Cursoes.Where(x => x.CodigoCurso == Id).First();
                DatCurso.Certificacion = curso.Certificacion;
                DatCurso.CodigoCurso = curso.CodigoCurso;
                DatCurso.Duracion = curso.Duracion;
                DatCurso.Estado = Convert.ToBoolean(curso.Estado);
                DatCurso.Inversion = curso.Inversion;
                DatCurso.MaterialDidactico = curso.MaterialDidactico;
                DatCurso.Metodologia = curso.Metodologia;
                DatCurso.NombreCurso = curso.NombreCurso;
                DatCurso.ObjetivoCurso = curso.ObjetivoCurso;
                DatCurso.IdSede = Convert.ToInt32(curso.IdSede);

                sc.Database.Connection.Close();


            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }
            return DatCurso;

        }

    }
}
