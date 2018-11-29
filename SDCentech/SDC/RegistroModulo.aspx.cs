using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;

namespace SDC
{
    public partial class RegistroModulo : System.Web.UI.Page
    {
        private IModulo mod;

        public RegistroModulo()
        {
            mod = new MModulo();

        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            string codigoModulo = txtCodigo.Text;
            int creditos = Convert.ToInt32(txtCreditos.Text);
            string duracion = txtDuracion.Text;
            string nombreModulo = txtNombreModulo.Text;

            GuardarModulo(codigoModulo, creditos, duracion, nombreModulo);
            Response.Redirect("Modulo.aspx?exito=" + 2 + "&nombreModuloAgre=" + nombreModulo);

        }

        protected void GuardarModulo(string codigoModulo, int creditos, string duracion, string nombreModulo)
        {
            try
            {
                DATA.Modulo modulo = new DATA.Modulo
                {
                    CodigoModulo = codigoModulo,
                    Creditos = creditos,
                    Duracion = duracion,
                    NombreModulo = nombreModulo,
                    Estado = 1
                };

                mod.RegistroModulo(modulo);
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx?error=" + ex);
            }

        }


    }
}
