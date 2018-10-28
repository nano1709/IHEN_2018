using System;

namespace SDC
{
    public partial class Tecnico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
