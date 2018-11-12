using SDC.BLL;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;
using System.Text;

namespace SDC
{
    public partial class Profesor : System.Web.UI.Page
    {
        private IProfesor profe;
        public String Fila;

        public Profesor()
        {
            profe = new MProfesor();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad seg = new Seguridad();

            string cedula = Request.QueryString["Cedula"];
            string canton = Request.QueryString["Canton"];
            string carrera = Request.QueryString["CarreraTecnica"];
            string correo = Request.QueryString["CorreoElectronico"];
            string direccionTrabajo = Request.QueryString["DireccionTrabajo"];
            string distrito = Request.QueryString["Distrito"];
            string domexacto = Request.QueryString["DomicilioExacto"];
            string edad = Request.QueryString["Edad"];
            string fechaFinalizacion = Request.QueryString["FechaFinalizacion"];
            string fechaIngreso = Request.QueryString["FechaIngreso"];
            string fechaInicio = Request.QueryString["fechaInicio"];
            string fechaNacimiento = Request.QueryString["FechaNacimiento"];
            string genero = Request.QueryString["Genero"];
            string gradoAcademico = Request.QueryString["GradoAcademico"];
            string institucion = Request.QueryString["Institucion"];
            string lugarTrabajo = Request.QueryString["LugarTrabajo"];
            string nombre = Request.QueryString["Nombre"];
            string nombreBanco = Request.QueryString["NombreBanco"];
            string numeroCuenta = Request.QueryString["NumeroCuenta"];
            string provincia = Request.QueryString["Provinica"];
            string telDomicilio = Request.QueryString["TelefonoDomicilio"];
            string telMovil = Request.QueryString["TelefonoMovil"];
            string telefonoTrabajo = Request.QueryString["TelefonoTrabajo"];


            string deleteid = Request.QueryString["deleteid"];
            string editid = Request.QueryString["editid"];

            string exitoModificar = Request.QueryString["exito"];
            string nombreProfeAgregado = Request.QueryString["nombreProfeAgre"];
            string nombreProfeEliminado = Request.QueryString["nombreProfeEli"];
            string nombreProfeModi = Request.QueryString["nombreProfeModi"];


            if (Convert.ToInt32(exitoModificar) == 2)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Profesor " + nombreProfeModi + " modificado con éxito";
            }
            else if (Convert.ToInt32(exitoModificar) == 1)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Se agregó el profesor: " + nombreProfeAgregado;
            }
            else if (Convert.ToInt32(exitoModificar) == 3)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerText = "Se eliminó al estudiante: " + nombreProfeEliminado;
            }
            else if (exitoModificar == null)
            {

            }
            else
            {
                mensajeError.Visible = true;
                textoMensaje.InnerText = "Error al actualizar estudiante";
            }

            if (deleteid != null)
            {
                EliminarProfesor(Convert.ToInt32(deleteid), nombre, carrera, correo);
            }
            else if (editid != null)
            {
                Response.Redirect("ModificarProfesor.aspx");
            }

            var listaProfesores = profe.ListaProfesor().Where(x => x.Estado == true);
            var lista = listaProfesores.Select(x =>
            new
            {
                x.Cedula,
                x.Canton,
                x.CarreraTecnica,
                x.CorreoElectronico,
                x.DireccionTrabajo,
                x.Distrito,
                x.DomicilioExacto,
                x.Edad,
                x.FechaFinalizacion,
                x.FechaIngreso,
                x.FechaInicio,
                x.FechaNacimiento,
                x.Genero,
                x.GradoAcademico,
                x.Institucion,
                x.LugarTrabajo,
                x.Nombre,
                x.NombreBanco,
                x.NumeroCuenta,
                x.Provincia,
                x.TelefonoDomicilio,
                x.TelefonoMovil,
                x.TelefonoTrabajo,
                x.IdSede
            }).ToList();

            var listaSedes = profe.ListaSede();
            var listaS = listaSedes.Select(x =>
            new
            {
                x.IdSede,
                x.NombreSede,
            }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in lista)
            {
                sb.Append("<TR>");

                sb.Append("<TD>");
                sb.Append(item.Cedula);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Nombre);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.CarreraTecnica);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.FechaIngreso);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.TelefonoMovil);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.CorreoElectronico);
                sb.Append("</TD>");
                sb.Append("<TD>");
                foreach (var item2 in listaS)
                {
                    if (item.IdSede == item2.IdSede)
                    {
                        sb.Append(item2.NombreSede);
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.Append("</TD>");
                sb.Append("<TD>");

                var datos = item.Cedula + "§"
                    + item.Canton + "§" + item.CarreraTecnica + "§" + item.CorreoElectronico + "§" + item.DireccionTrabajo + "§"
                    + item.Distrito + "§" + item.DomicilioExacto + "§" + item.Edad + "§" + item.FechaFinalizacion + "§" + item.FechaIngreso + "§" +
                    item.FechaInicio + "§" + item.FechaNacimiento + "§" + item.Genero + "§" + item.GradoAcademico + "§" + item.Institucion + "§"
                    + item.LugarTrabajo + "§" + item.Nombre + "§" + item.NombreBanco + "§" + item.NumeroCuenta + "§" + item.Provincia + "§" +
                    item.TelefonoDomicilio + "§" + item.TelefonoMovil + "§" + item.TelefonoTrabajo + "§" + item.IdSede;
                string newDatos = seg.Encriptar(datos);

                sb.Append("<button class='btn btn-info editar' type='button' value='" + newDatos + "'>Ver</button>");
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append("<button class='btn btn-danger borrar' type='button' value='" + item.Cedula + "§"
                    + item.Nombre + "§" + item.CarreraTecnica + "§"
                    + item.CorreoElectronico + "'>Eliminar</button>");
                sb.Append("</TD>");

                sb.Append("</TR>");

                Fila = sb.ToString();
            }
        }

        protected void EliminarProfesor(int cedula, string nombre, string carrera, string correo)
        {
            try
            {
                DATA.Profesor profesor = new DATA.Profesor
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    CarreraTecnica = carrera,
                    CorreoElectronico = correo
                };
                profe.EliminarProfesor(profesor);
            }
            catch (Exception ex)
            {
                throw;
            }

            Response.Redirect("Profesor.aspx?exito=" + 3 + "&nombreProfeEli=" + nombre + " ");
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroProfesor.aspx");
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarProfesor.aspx");
        }
    }
}
