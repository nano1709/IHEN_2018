using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MProfesor : MDB, IProfesor
    {
        DocenciaEntities sc = new DocenciaEntities();
        DAL.Profesor registroProfe = new DAL.Profesor();
        DATA.Profesor listaCedulaProfe = new DATA.Profesor();


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
            catch (Exception ex)
            {
                Console.Write(ex);
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
            catch (Exception ex)
            {
                Console.Write(ex);
            }

        }

        public void ActualizarProfesor(DATA.Profesor profesor)
        {
            try
            {
                sc.Database.Connection.Open();

                var actuProfe = sc.Profesors.Where(x => x.Cedula == profesor.Cedula).First();
                actuProfe.Nombre = profesor.Nombre;
                actuProfe.Cedula = Convert.ToInt32(profesor.Cedula);
                actuProfe.Canton = profesor.Canton;
                actuProfe.CarreraTecnica = profesor.CarreraTecnica;
                actuProfe.CorreoElectronico = profesor.CorreoElectronico;
                actuProfe.DireccionTrabajo = profesor.DireccionTrabajo;
                actuProfe.Distrito = profesor.Distrito;
                actuProfe.DomicilioExacto = profesor.DomicilioExacto;
                actuProfe.Edad = Convert.ToInt32(profesor.Edad);
                actuProfe.Estado = Convert.ToBoolean(profesor.Estado);
                actuProfe.FechaFinalizacion = profesor.FechaFinalizacion;
                actuProfe.FechaIngreso = profesor.FechaIngreso;
                actuProfe.FechaInicio = profesor.FechaInicio;
                actuProfe.FechaNacimiento = profesor.FechaNacimiento;
                actuProfe.Genero = Convert.ToString(profesor.Genero);
                actuProfe.GradoAcademico = profesor.GradoAcademico;
                actuProfe.Institucion = profesor.Institucion;
                actuProfe.LugarTrabajo = profesor.LugarTrabajo;
                actuProfe.NombreBanco = profesor.NombreBanco;
                actuProfe.NumeroCuenta = Convert.ToInt32(profesor.NumeroCuenta);
                actuProfe.Provincia = profesor.Provincia;
                actuProfe.TelefonoDomicilio = Convert.ToInt32(profesor.TelefonoDomicilio);
                actuProfe.TelefonoMovil = Convert.ToInt32(profesor.TelefonoMovil);
                actuProfe.TelefonoTrabajo = Convert.ToInt32(profesor.TelefonoTrabajo);


                sc.SaveChanges();

                sc.Database.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public void EliminarProfesor(DATA.Profesor profesor)
        {
            try
            {
                //No se elimina, se inhabilita
                sc.Database.Connection.Open();

                var EliminarProfesor = sc.Profesors.Where(x => x.Cedula == profesor.Cedula).First();
                EliminarProfesor.Estado = false;

                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public DATA.Profesor SeleccionarProfesorCedula(int cedula)
        {
            try
            {


                var profesor = sc.Profesors.Where(x => x.Cedula == cedula).First();
                listaCedulaProfe.Nombre = profesor.Nombre;
                listaCedulaProfe.Cedula = Convert.ToInt32(profesor.Cedula);
                listaCedulaProfe.Canton = profesor.Canton;
                listaCedulaProfe.CarreraTecnica = profesor.CarreraTecnica;
                listaCedulaProfe.CorreoElectronico = profesor.CorreoElectronico;
                listaCedulaProfe.DireccionTrabajo = profesor.DireccionTrabajo;
                listaCedulaProfe.Distrito = profesor.Distrito;
                listaCedulaProfe.DomicilioExacto = profesor.DomicilioExacto;
                listaCedulaProfe.Edad = Convert.ToInt32(profesor.Edad);
                listaCedulaProfe.Estado = Convert.ToByte(profesor.Estado);
                listaCedulaProfe.FechaFinalizacion = profesor.FechaFinalizacion;
                listaCedulaProfe.FechaIngreso = profesor.FechaIngreso;
                listaCedulaProfe.FechaInicio = profesor.FechaInicio;
                listaCedulaProfe.FechaNacimiento = profesor.FechaNacimiento;
                listaCedulaProfe.Genero = Convert.ToChar(profesor.Genero);
                listaCedulaProfe.GradoAcademico = profesor.GradoAcademico;
                listaCedulaProfe.Institucion = profesor.Institucion;
                listaCedulaProfe.LugarTrabajo = profesor.LugarTrabajo;
                listaCedulaProfe.NombreBanco = profesor.NombreBanco;
                listaCedulaProfe.NumeroCuenta = Convert.ToInt32(profesor.NumeroCuenta);
                listaCedulaProfe.Provincia = profesor.Provincia;
                listaCedulaProfe.TelefonoDomicilio = Convert.ToInt32(profesor.TelefonoDomicilio);
                listaCedulaProfe.TelefonoMovil = Convert.ToInt32(profesor.TelefonoMovil);
                listaCedulaProfe.TelefonoTrabajo = Convert.ToInt32(profesor.TelefonoTrabajo);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return listaCedulaProfe;
        }
    }
}