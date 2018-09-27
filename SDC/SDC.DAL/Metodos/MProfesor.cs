using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using SDC.DATA;

namespace SDC.DAL.Metodos
{
    public class MProfesor : MDB, IProfesor
    {
        DocenciaEntities1 sc = new DocenciaEntities1();
        DAL.Profesor registroProfe = new DAL.Profesor();


        private static MProfesor instancia;

        public static MProfesor Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MProfesor();
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
        public List<Profesor> ListaProfesor()
        {
            List<DAL.Profesor> lista = new List<DAL.Profesor>();

            try
            {

                _db.Open();
                lista = conexion.Profesors.ToList();
                _db.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public void RegistroProfesor(DATA.Profesor profesor)
        {
            try
            {
                sc.Database.Connection.Open();

                registroProfe.Nombre = profesor.Nombre;
                registroProfe.Cedula = Convert.ToInt32(profesor.Cedula);
                registroProfe.Canton = profesor.Canton;
                registroProfe.CarreraTecnica = profesor.CarreraTecnica;
                registroProfe.CorreoElectronico = profesor.CorreoElectronico;
                registroProfe.DireccionTrabajo = profesor.DireccionTrabajo;
                registroProfe.Distrito = profesor.Distrito;
                registroProfe.DomicilioExacto = profesor.DomicilioExacto;
                registroProfe.Edad = Convert.ToInt32(profesor.Edad);
                registroProfe.Estado = Convert.ToBoolean(profesor.Estado);
                registroProfe.FechaFinalizacion = profesor.FechaFinalizacion;
                registroProfe.FechaIngreso = profesor.FechaIngreso;
                registroProfe.FechaInicio = profesor.FechaInicio;
                registroProfe.FechaNacimiento = profesor.FechaNacimiento;
                registroProfe.Genero = Convert.ToString(profesor.Genero);
                registroProfe.GradoAcademico = profesor.GradoAcademico;
                registroProfe.Institucion = profesor.Institucion;
                registroProfe.LugarTrabajo = profesor.LugarTrabajo;
                registroProfe.NombreBanco = profesor.NombreBanco;
                registroProfe.NumeroCuenta = Convert.ToInt32(profesor.NumeroCuenta);
                registroProfe.Provincia = profesor.Provincia;
                registroProfe.TelefonoDomicilio = Convert.ToInt32(profesor.TelefonoDomicilio);
                registroProfe.TelefonoMovil = Convert.ToInt32(profesor.TelefonoMovil);
                registroProfe.TelefonoTrabajo = Convert.ToInt32(profesor.TelefonoTrabajo);


                sc.Profesors.Add(registroProfe);

                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }



    }
}
