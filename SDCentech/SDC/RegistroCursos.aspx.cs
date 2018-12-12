using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;


namespace SDC
{
    public partial class RegistroCurso : System.Web.UI.Page
    {

        public string error = "NE";
        private ICurso cur;
        public RegistroCurso()
        {
            cur = new MCurso();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

            string er = Convert.ToString(Session["ErrorRC"]);
            var sedes = cur.ListaSede();

            if (er != "")
            {
                error = "RC";
            }

            foreach (var item in sedes)
            {
                ddlSede.Items.Insert(Convert.ToInt32(item.IdSede), item.NombreSede.ToString());
            }
            ddlSede.DataBind();

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {


            var Codigo = txtCodigoCurso.Text;
            var Duracion = txtDuracion.Text;
            var certificacion = txtCertificacion.Text;
            var inversion = txtInversion.Text;
            var material = txtMaterial.Text;
            var metodologia = txtMetodologia.Text;
            var NombreCurso = txtNombreCurso.Text;
            var ObjetivoCurso = txtObjetivoCurso.Text;
            int idSede = Convert.ToInt32(ddlSede.SelectedIndex);




            try
            {


                // Response.Write("<script lengue>swal('Error', 'El usuario o contraseña son incorrectos', 'error');</ script>");


                if (Codigo != "" && Duracion != "" && certificacion != "" && inversion != "" && material != "" && metodologia != "" && NombreCurso != "" && ObjetivoCurso != "")
                {


                    DATA.Curso curso = new DATA.Curso
                    {
                        Certificacion = certificacion,
                        CodigoCurso = Codigo,
                        Duracion = Duracion,
                        Estado = true,
                        Inversion = inversion,
                        MaterialDidactico = material,
                        Metodologia = metodologia,
                        NombreCurso = NombreCurso,
                        ObjetivoCurso = ObjetivoCurso,
                        IdSede = idSede

                    };


                    cur.RegistroCurso(curso);

                    Response.Redirect("Curso.aspx");

                }
                else
                {

                    ClientScript.RegisterStartupScript(GetType(), "MostrarMensaje", "Mensaje();", true);


                }


            }
            catch (Exception)
            {

                throw;
            }


        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Curso.aspx");

        }
    }
}