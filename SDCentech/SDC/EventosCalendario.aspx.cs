using SDC.BLL;
using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace SDC
{
    public partial class EventosCalendario : System.Web.UI.Page
    {


        private IEventosCale eveCale;
        public String Fila;

        public EventosCalendario()
        {
            eveCale = new MEventosCale();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            Seguridad seg = new Seguridad();

            string id = Request.QueryString["id"];
            string titulo = Request.QueryString["Titulo"];
            string empieza = Request.QueryString["Empieza"];
            string termina = Request.QueryString["Termina"];
            string url = Request.QueryString["Url"];
            string color = Request.QueryString["color"];


            string deleteid = Request.QueryString["deleteid"];
            string editid = Request.QueryString["editid"];

            string exitoModificar = Request.QueryString["exito"];
            string nombreEveModi = Request.QueryString["nombreEveModi"];
            string nombreEveAgregado = Request.QueryString["nombreEveAgre"];
            string nombreEveEliminado = Request.QueryString["nombreEvecEli"];

            if (Convert.ToInt32(exitoModificar) == 1)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Evento " + nombreEveModi + " modificado con éxito";
            }
            else if (Convert.ToInt32(exitoModificar) == 2)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Se agregó el evento: " + nombreEveAgregado;
            }
            else if (Convert.ToInt32(exitoModificar) == 3)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerText = "Se eliminó el evento: " + nombreEveEliminado;
            }
            else if (exitoModificar == null)
            {

            }
            else
            {
                mensajeError.Visible = true;
                textoMensaje.InnerText = "Error al actualizar el evento";
            }

            if (deleteid != null)
            {
                Eliminarevento(Convert.ToInt32(deleteid), titulo);
            }
            else if (editid != null)
            {
                Response.Redirect("ModificarEveCale.aspx");
            }
            var listaTecnicos = eveCale.ListaEvento();
            var lista = listaTecnicos.Select(x =>
            new
            {
                x.id,
                x.title,
                x.start,
                x.end,
                x.url,
                x.className

            }).ToList();


            StringBuilder sb = new StringBuilder();

            foreach (var item in lista)
            {
                sb.Append("<TR>");

                sb.Append("<TD>");
                sb.Append(item.id);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.title);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.start);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.end);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.url);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.className);
                sb.Append("</TD>");
                sb.Append("<TD>");

                var datos = item.id + "§" +
                    item.title + "§" +
                    item.start + "§" +
                    item.end + "§" +
                    item.url + "§" +
                    item.className;

                string newDatos = seg.Encriptar(datos);
                sb.Append("<button class='btn btn-info editar' type='button' value='" + newDatos + "'>Ver</button>");
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append("<button class='btn btn-danger borrar' type='button' value='" + item.id + "§" + item.title + "§" + "'>Eliminar</button>");
                sb.Append("</TD>");

                sb.Append("</TR>");

                Fila = sb.ToString();
            }

        }
        protected void Eliminarevento(int codigo, string titulo)
        {
            try
            {
                var eventos = eveCale.SeleccionarEvento(codigo);
                eveCale.EliminarEvento(eventos);
            }
            catch (Exception ex)
            {
                throw;
            }

            Response.Redirect("EventosCalendario.aspx?exito=" + 3 + "&nombreEveEli=" + titulo);
        }

        protected void AddEventosCale_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEventosCale.aspx");
        }

        protected void btnDevolverCale_Click(object sender, EventArgs e)
        {
            Response.Redirect("Calendario.aspx");
        }

    }
}
