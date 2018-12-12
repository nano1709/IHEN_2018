using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;

namespace SDC
{
    public partial class ModificarEventosCale : System.Web.UI.Page
    {
        private IEventosCale eve;

        public ModificarEventosCale()
        {
            eve = new MEventosCale();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.Seguridad seg = new BLL.Seguridad();


                var query = Request.QueryString["editid"];
                var queryReplace = query.Replace(' ', '+');
                var editid = seg.Decriptar(queryReplace);

                var lista = editid.Split('§');
                string id = lista[0];
                string titulo = lista[1];
                var empieza = lista[2];
                var termina = lista[3];
                string url = lista[4];
                string color = lista[5];



                if (editid != null || id != null)
                {
                    txtId.Text = id;
                    txtTitulo.Text = titulo;
                    ddlColor.Items.FindByValue(color).Selected = true;
                    txtFechaFinal.Value = Convert.ToDateTime(termina).ToString("yyyy-MM-ddThh:mm");
                    txtFechaInicio.Value = Convert.ToDateTime(empieza).ToString("yyyy-MM-ddThh:mm");
                    txtPagWeb.Text = url;

                }
                else
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(txtId.Text);
            string titulo = txtTitulo.Text;
            string empieza = txtFechaInicio.Value.ToString();
            string termina = txtFechaFinal.Value.ToString();
            string color = ddlColor.SelectedValue;
            string url = txtPagWeb.Text;


            EditarEvento(id, titulo, empieza, termina, color, url);
            Response.Redirect("EventosCalendario.aspx?exito=" + 1 + "&nombreEveModi=" + titulo);
        }

        protected void EditarEvento(int id, string titulo, string empieza, string termina, string color, string url)
        {
            try
            {

                var select = eve.SeleccionarEvento(id);
                select.title = titulo;
                select.start = Convert.ToDateTime(empieza);
                select.end = Convert.ToDateTime(termina);
                select.className = color;
                select.url = url;

                eve.ActualizarEvento(select);
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
