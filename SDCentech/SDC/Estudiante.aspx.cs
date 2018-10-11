using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SDC
{
    public partial class Estudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AgregarEstudiante_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEstudiante.aspx");
        }
    }
}