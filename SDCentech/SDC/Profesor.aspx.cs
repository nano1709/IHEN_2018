using System;

namespace SDC
{
    public partial class Profesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
