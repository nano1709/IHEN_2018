using SDC.BLL;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace SDC
{
    public partial class Tecnico : System.Web.UI.Page
    {
        private ITecnico tec;
        public String Fila;

        public Tecnico()
        {
            tec = new MTecnico();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            Seguridad seg = new Seguridad();

            string codigo = Request.QueryString["Codigo"];
            string nombre = Request.QueryString["Nombre"];
            string duracion = Request.QueryString["Duracion"];
            string requisitos = Request.QueryString["Requisitos"];
            string perfilOcupacional = Request.QueryString["PerfilOcupacional"];
            string practicaProfesional = Request.QueryString["PracticaProf"];


            string deleteid = Request.QueryString["deleteid"];
            string editid = Request.QueryString["editid"];

            string exitoModificar = Request.QueryString["exito"];
            string nombreTecModi = Request.QueryString["nombreTecModi"];
            string nombreTecAgregado = Request.QueryString["nombreTecAgre"];
            string nombreTecEliminado = Request.QueryString["nombreTecEli"];

            if (Convert.ToInt32(exitoModificar) == 1)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Técnico " + nombreTecModi + " modificado con éxito";
            }
            else if (Convert.ToInt32(exitoModificar) == 2)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Se agregó el técnico: " + nombreTecAgregado;
            }
            else if (Convert.ToInt32(exitoModificar) == 3)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerText = "Se eliminó el técnico: " + nombreTecEliminado;
            }
            else if (exitoModificar == null)
            {

            }
            else
            {
                mensajeError.Visible = true;
                textoMensaje.InnerText = "Error al actualizar técnico";
            }

            if (deleteid != null)
            {
                EliminarTecnico(Convert.ToInt32(deleteid), nombre);
            }
            else if (editid != null)
            {
                Response.Redirect("ModificarTecnico.aspx");
            }
            var listaTecnicos = tec.ListaTecnico().Where(x => x.Estado == true);
            var lista = listaTecnicos.Select(x =>
            new
            {
                x.CodigoTecnico,
                x.NombreTecnico,
                x.PerfilOcupacional,
                x.Duracion,
                x.PracticaProf,
                x.Requisitos

            }).ToList();


            StringBuilder sb = new StringBuilder();

            foreach (var item in lista)
            {
                sb.Append("<TR>");

                sb.Append("<TD>");
                sb.Append(item.CodigoTecnico);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.NombreTecnico);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.PerfilOcupacional);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Duracion);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.PracticaProf);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Requisitos);
                sb.Append("</TD>");
                sb.Append("<TD>");

                var datos = item.CodigoTecnico + "§" +
                    item.NombreTecnico + "§" +
                    item.PerfilOcupacional + "§" +
                    item.Duracion + "§" +
                    item.PracticaProf + "§" +
                    item.Requisitos;

                string newDatos = seg.Encriptar(datos);
                sb.Append("<button class='btn btn-info editar' type='button' value='" + newDatos + "'>Ver</button>");
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append("<button class='btn btn-danger borrar' type='button' value='" + item.CodigoTecnico + "§" + item.NombreTecnico + "§" + "'>Eliminar</button>");
                sb.Append("</TD>");

                sb.Append("</TR>");

                Fila = sb.ToString();
            }

        }
        protected void EliminarTecnico(int codigo, string nombre)
        {
            try
            {
                DATA.Tecnico tecnico = new DATA.Tecnico
                {
                    CodigoTecnico = Convert.ToString(codigo),
                    NombreTecnico = nombre,
                };
                tec.EliminarTecnico(tecnico);
            }
            catch (Exception ex)
            {
                throw;
            }

            Response.Redirect("Tecnico.aspx?exito=" + 3 + "&nombreTecEli=" + nombre);
        }


        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroTecnicos.aspx");
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarTecnico.aspx");
        }
    }
}
