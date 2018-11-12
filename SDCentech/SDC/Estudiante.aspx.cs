using SDC.BLL;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace SDC
{
    public partial class Estudiante : System.Web.UI.Page
    {
        private IEstudiante estu;
        public String Fila;

        public Estudiante()
        {
            estu = new MEstudiante();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad seg = new Seguridad();

            string cedula = Request.QueryString["Cedula"];
            string nombre = Request.QueryString["Nombre"];
            string apellido = Request.QueryString["Apellido"];
            string fechaNacimiento = Request.QueryString["FechaNacimiento"];
            string fechaIngreo = Request.QueryString["FechaIngreso"];
            string carreraTecnica = Request.QueryString["CarreraTecnica"];
            string edad = Request.QueryString["Edad"];
            string genero = Request.QueryString["Genero"];
            string telefonoMovil = Request.QueryString["TelefonoMovil"];
            string telefonoDomicilio = Request.QueryString["TelefonoDomicilio"];
            string correoElectronico = Request.QueryString["CorreoElectronico"];
            string referenciaPersonal = Request.QueryString["ReferenciaPersonal"];
            string telefonoReferencia = Request.QueryString["telefonoReferencia"];
            string provincia = Request.QueryString["Provincia"];
            string canton = Request.QueryString["Canton"];
            string distrito = Request.QueryString["distrito"];
            string domicilioExacto = Request.QueryString["DomicilioExacto"];

            string deleteid = Request.QueryString["deleteid"];
            string editid = Request.QueryString["editid"];

            string exitoModificar = Request.QueryString["exito"];
            string nombreEstuModi = Request.QueryString["nombreEstuModi"];
            string nombreEstuAgregado = Request.QueryString["nombreEstuAgre"];
            string nombreEstuEliminado = Request.QueryString["nombreEstuEli"];

            if (Convert.ToInt32(exitoModificar) == 1)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Estudiante " + nombreEstuModi + " modificado con éxito";
            }
            else if (Convert.ToInt32(exitoModificar) == 2)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Se agregó el estudiante: " + nombreEstuAgregado;
            }
            else if (Convert.ToInt32(exitoModificar) == 3)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerText = "Se eliminó al estudiante: " + nombreEstuEliminado;
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
                EliminarEstudiante(Convert.ToInt32(deleteid), nombre, apellido);
            }
            else if (editid != null)
            {
                Response.Redirect("ModificarEstudiante.aspx");
            }

            var listaEstudinates = estu.ListaEstudiante().Where(x => x.Estado == true);
            var lista = listaEstudinates.Select(x =>
            new
            {
                x.Cedula,
                x.Nombre,
                x.Apellido,
                x.FechaIngreso,
                x.CarreraTecnica,
                x.FechaNacimiento,
                x.Edad,
                x.Genero,
                x.TelefonoMovil,
                x.TelefonoDomicilio,
                x.CorreoElectronico,
                x.ReferenciaPersonal,
                x.TelefonoReferencia,
                x.Provincia,
                x.Canton,
                x.Distrito,
                x.DomicilioExacto,
                x.IdSede
            }).ToList();

            var listaSedes = estu.ListaSede();
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
                    + item.Nombre + "§" + item.Apellido + "§" + item.FechaIngreso + "§" + item.CarreraTecnica + "§"
                    + item.FechaNacimiento + "§" + item.Genero + "§" + item.TelefonoMovil + "§"
                    + item.TelefonoDomicilio + "§" + item.CorreoElectronico + "§" + item.ReferenciaPersonal + "§"
                    + item.TelefonoReferencia + "§" + item.Provincia + "§" + item.Canton + "§" + item.Distrito + "§"
                    + item.DomicilioExacto + "§" + item.Edad + "§" + item.IdSede;

                string newDatos = seg.Encriptar(datos);
                sb.Append("<button class='btn btn-info editar' type='button' value='" + newDatos + "'>Ver</button>");
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append("<button class='btn btn-danger borrar' type='button' value='" + item.Cedula + "§" + item.Nombre + "§" + item.Apellido + "§" + "'>Eliminar</button>");
                sb.Append("</TD>");

                sb.Append("</TR>");

                Fila = sb.ToString();
            }

        }


        protected void EliminarEstudiante(int cedula, string nombre, string apellido)
        {
            try
            {
                DATA.Estudiante estudiante = new DATA.Estudiante
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido
                };
                estu.EliminarEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                throw;
            }

            Response.Redirect("Estudiante.aspx?exito=" + 3 + "&nombreEstuEli=" + nombre + " " + apellido);
        }



        protected void AgregarEstudiante_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEstudiante.aspx");

        }

    }
}