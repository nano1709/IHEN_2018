using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;

namespace SDC
{
    public partial class RegistroEventosCale : System.Web.UI.Page
    {
        private IEventosCale eve;

        public RegistroEventosCale()
        {
            eve = new MEventosCale();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            var inicio = txtFechaInicio.Value;
            var final = txtFechaFinal.Value;
            string url = txtPagWeb.Text;
            string color = ddlColor.SelectedValue;


            GuardarEvento(titulo, inicio, final, url, color);
            Response.Redirect("EventosCalendario.aspx?exito=" + 2 + "&nombreEveAgre=" + titulo);
        }

        protected void GuardarEvento(string titulo, string inicio, string final, string url, string color)
        {
            try
            {
                DATA.Eventos evento= new DATA.Eventos
                {
                    title = titulo,
                    start = Convert.ToDateTime(inicio),
                    end = Convert.ToDateTime(final),
                    url = url,
                    className = color

                };

                eve.RegistroEvento(evento);
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx?error=" + ex);
            }

        }
    }
}