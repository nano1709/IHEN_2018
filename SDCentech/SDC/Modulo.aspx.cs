using SDC.BLL;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;


namespace SDC
{
    public partial class Modulo : System.Web.UI.Page
    {
        private IModulo mod;
        public String Fila;

        public Modulo()
        {
            mod = new MModulo();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad seg = new Seguridad();

            string codigoModulo = Request.QueryString["CodigoModulo"];
            string creditos = Request.QueryString["Creditos"];
            string duracion = Request.QueryString["Duracion"];
            string nombreModulo = Request.QueryString["NombreModulo"];

            string deleteid = Request.QueryString["deleteid"];
            string editid = Request.QueryString["editid"];

            string exitoModificar = Request.QueryString["exito"];
            string nombreModuModi = Request.QueryString["nombreModuModi"];
            string nombreModuAgregado = Request.QueryString["nombreModuloAgre"];
            string nombreModuEliminado = Request.QueryString["nombreModuEli"];


            if (Convert.ToInt32(exitoModificar) == 1)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Módulo " + nombreModuModi + " modificado con éxito";
            }
            else if (Convert.ToInt32(exitoModificar) == 2)
            {
                mensaje.Visible = true;
                textoMensaje.InnerText = "Se agregó el módulo: " + nombreModuAgregado;
            }
            else if (Convert.ToInt32(exitoModificar) == 3)
            {
                mensajeError.Visible = true;
                textoMensajeError.InnerText = "Se eliminó el módulo: " + nombreModuEliminado;
            }
            else if (exitoModificar == null)
            {

            }
            else
            {
                mensajeError.Visible = true;
                textoMensaje.InnerText = "Error al actualizar módulo";
            }

            if (deleteid != null)
            {
                EliminarModulo(deleteid, nombreModulo, Convert.ToInt32(creditos));
            }
            else if (editid != null)
            {
                Response.Redirect("ModificarModulo.aspx");
            }

            var listaModulos = mod.ListaModulo().Where(x => x.Estado == true);
            var lista = listaModulos.Select(x =>
            new
            {
                x.CodigoModulo,
                x.Creditos,
                x.Duracion,
                x.NombreModulo,

            }).ToList();



            StringBuilder sb = new StringBuilder();

            foreach (var item in lista)
            {
                sb.Append("<TR>");

                sb.Append("<TD>");
                sb.Append(item.CodigoModulo);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.NombreModulo);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Creditos);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Duracion);
                sb.Append("</TD>");
                sb.Append("<TD>");

                var datos = item.CodigoModulo + "§"
                    + item.NombreModulo + "§" + item.Creditos + "§" + item.Duracion;

                string newDatos = seg.Encriptar(datos);
                sb.Append("<button class='btn btn-info editar' type='button' value='" + newDatos + "'>Ver</button>");
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append("<button class='btn btn-danger borrar' type='button' value='" + item.CodigoModulo + "§" + item.NombreModulo + "§" + item.Creditos + "§" + "'>Eliminar</button>");
                sb.Append("</TD>");

                sb.Append("</TR>");

                Fila = sb.ToString();
            }


        }

        protected void EliminarModulo(string codigo, string nombreModulo, int creditos)
        {
            try
            {
                DATA.Modulo modulo = new DATA.Modulo
                {
                    CodigoModulo = codigo,
                    NombreModulo = nombreModulo,
                    Creditos = creditos
                };
                mod.EliminarModulo(modulo);
            }
            catch (Exception ex)
            {
                throw;
            }

            Response.Redirect("Modulo.aspx?exito=" + 3 + "&nombreModuEli=" + nombreModulo);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroModulo.aspx");
        }
    }
}
