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
    public class MEstudiante : MDB, IEstudiante
    {

        DocenciaEntities1 sc = new DocenciaEntities1();
        DAL.Estudiante registroEstu = new DAL.Estudiante();


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

        public List<DAL.Estudiante> ListaEstudiante()
        {
            List<DAL.Estudiante> lista = new List<DAL.Estudiante>();

            try
            {

                _db.Open();
                lista = conexion.Estudiantes.ToList();
                _db.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public void RegistroEstudiante(DATA.Estudiante estudiante)
        {
            try
            {
                sc.Database.Connection.Open();

                registroEstu.Nombre = estudiante.Nombre;
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
                registroEstu.LugarTrabajo = estudiante.LugarTrabajo;
                registroEstu.Cargo = estudiante.Cargo;
                registroEstu.TelefonoTrabajo = estudiante.TelefonoTrabajo;
                registroEstu.DireccionTrabajo = estudiante.DireccionTrabajo;
                registroEstu.GradoAcademico = estudiante.GradoAcademico;
                registroEstu.Institucion = estudiante.Institucion;
                registroEstu.Estado = Convert.ToBoolean(estudiante.Estado);


                sc.Estudiantes.Add(registroEstu);

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
