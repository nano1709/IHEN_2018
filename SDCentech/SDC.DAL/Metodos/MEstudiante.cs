using SDC.DAL.Interface;
using SDC.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SDC.DAL.Metodos
{
    public class MEstudiante : MDB, IEstudiante
    {

        DocenciaEntities sc = new DocenciaEntities();
        DAL.Estudiante registroEstu = new DAL.Estudiante();
        DATA.Estudiante listaCedulaEstu = new DATA.Estudiante();

        private static MEstudiante instancia;

        public static MEstudiante Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new MEstudiante();
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

        public List<DAL.Sede> ListaSede()
        {
            List<DAL.Sede> lista = new List<DAL.Sede>();

            try
            {

                _db.Open();
                lista = conexion.Sedes.ToList();
                _db.Close();

            }
            catch (Exception ex)
            {

                Console.Write(ex);
            }
            return lista;
        }


        public List<DAL.Estudiante> ListaEstudiante()
        {
            List<DAL.Estudiante> lista = new List<DAL.Estudiante>();

            try
            {

                _db.Open();
                lista = conexion.Estudiantes.ToList();
                _db.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return lista;
        }

        public void RegistroEstudiante(DATA.Estudiante estudiante)
        {
            try
            {
                sc.Database.Connection.Open();

                registroEstu.Nombre = estudiante.Nombre;
                registroEstu.Apellido = estudiante.Apellido;
                registroEstu.Cedula = Convert.ToInt32(estudiante.Cedula);
                registroEstu.FechaIngreso = estudiante.FechaIngreso;
                registroEstu.CarreraTecnica = estudiante.CarreraTecnica;
                registroEstu.FechaNacimiento = estudiante.FechaNacimiento;
                registroEstu.Edad = Convert.ToInt32(estudiante.Edad);
                registroEstu.Genero = Convert.ToString(estudiante.Genero);
                registroEstu.TelefonoMovil = estudiante.TelefonoMovil;
                registroEstu.TelefonoDomicilio = estudiante.TelefonoDomicilio;
                registroEstu.CorreoElectronico = estudiante.CorreoElectronico;
                registroEstu.ReferenciaPersonal = estudiante.ReferenciaPersonal;
                registroEstu.TelefonoReferencia = estudiante.TelefonoReferencia;
                registroEstu.Provincia = estudiante.Provincia;
                registroEstu.Canton = estudiante.Canton;
                registroEstu.Distrito = estudiante.Distrito;
                registroEstu.DomicilioExacto = estudiante.DomicilioExacto;
                registroEstu.IdSede = estudiante.IdSede;

                registroEstu.Estado = Convert.ToBoolean(estudiante.Estado);


                sc.Estudiantes.Add(registroEstu);

                sc.SaveChanges();
                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void ActualizarEstudiante(DATA.Estudiante estudiante)
        {
            try
            {
                sc.Database.Connection.Open();

                var actuEstu = sc.Estudiantes.Where(x => x.Cedula == estudiante.Cedula).First();
                actuEstu.Nombre = estudiante.Nombre;
                actuEstu.Apellido = estudiante.Apellido;
                actuEstu.FechaIngreso = estudiante.FechaIngreso;
                actuEstu.CarreraTecnica = estudiante.CarreraTecnica;
                actuEstu.FechaNacimiento = estudiante.FechaNacimiento;
                actuEstu.Edad = estudiante.Edad;
                actuEstu.Genero = Convert.ToString(estudiante.Genero);
                actuEstu.TelefonoMovil = estudiante.TelefonoMovil;
                actuEstu.TelefonoDomicilio = estudiante.TelefonoDomicilio;
                actuEstu.CorreoElectronico = estudiante.CorreoElectronico;
                actuEstu.ReferenciaPersonal = estudiante.ReferenciaPersonal;
                actuEstu.TelefonoReferencia = estudiante.TelefonoReferencia;
                actuEstu.Provincia = estudiante.Provincia;
                actuEstu.Canton = estudiante.Canton;
                actuEstu.Distrito = estudiante.Distrito;
                actuEstu.DomicilioExacto = estudiante.DomicilioExacto;
                actuEstu.IdSede = estudiante.IdSede;

                actuEstu.Estado = actuEstu.Estado;

                sc.SaveChanges();

                sc.Database.Connection.Close();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


        }

        public void EliminarEstudiante(DATA.Estudiante estudiante)
        {
            try
            {
                //No se elimina, se inhabilita
                sc.Database.Connection.Open();

                var EliminarEstudiante = sc.Estudiantes.Where(x => x.Cedula == estudiante.Cedula).First();
                EliminarEstudiante.Estado = false;

                sc.SaveChanges();

                sc.Database.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


        }


        public DATA.Estudiante SeleccionarEstudianteCedula(int cedula)
        {


            try
            {
                var estudiante = sc.Estudiantes.Where(x => x.Cedula == cedula).First();
                listaCedulaEstu.Nombre = estudiante.Nombre;
                listaCedulaEstu.Apellido = estudiante.Apellido;
                listaCedulaEstu.FechaIngreso = estudiante.FechaIngreso;
                listaCedulaEstu.CarreraTecnica = estudiante.CarreraTecnica;
                listaCedulaEstu.FechaNacimiento = estudiante.FechaNacimiento;
                listaCedulaEstu.Edad = Convert.ToInt32(estudiante.Edad);
                listaCedulaEstu.Genero = estudiante.Genero;
                listaCedulaEstu.TelefonoMovil = estudiante.TelefonoMovil;
                listaCedulaEstu.TelefonoDomicilio = estudiante.TelefonoDomicilio;
                listaCedulaEstu.CorreoElectronico = estudiante.CorreoElectronico;
                listaCedulaEstu.ReferenciaPersonal = estudiante.ReferenciaPersonal;
                listaCedulaEstu.TelefonoReferencia = estudiante.TelefonoReferencia;
                listaCedulaEstu.Provincia = estudiante.Provincia;
                listaCedulaEstu.Canton = estudiante.Canton;
                listaCedulaEstu.Distrito = estudiante.Distrito;
                listaCedulaEstu.DomicilioExacto = estudiante.DomicilioExacto;
                listaCedulaEstu.IdSede = Convert.ToInt32(estudiante.IdSede);
                listaCedulaEstu.Estado = Convert.ToByte(estudiante.Estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaCedulaEstu;

        }


    }
}
