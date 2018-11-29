using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;

namespace SDC
{
    public partial class ModificacionCurso : System.Web.UI.Page
    {

        public string error = "NE";

        private ICurso cur;
        public ModificacionCurso()
        {
            cur = new MCurso();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Seguridad seg = new BLL.Seguridad();


            String Datos = Request.QueryString["dat"];
            //Datos = Datos.Replace("۝", "+");

            //var count = Convert.ToString(Session["Inf"]);

            if (Datos != null /*&& count == "" || (Datos != null && count == "X")*/)
            {

                //if (count == "X")
                //{
                //    Session["Inf"] = "XY";
                //}
                //else
                //{
                //    Session["Inf"] = "X";
                //}

                var desc = Datos;
                desc = desc.Replace("Ɲ", "+");
                desc = seg.Decriptar(desc);
                desc = desc.Replace("Ơ", " ").Replace("ƶ", "-");
                var datD = desc.Split('ὣ');

                txtCodigoCurso.Text = datD[1];
                txtNombreCurso.Text = datD[6];
                txtDuracion.Text = datD[2];
                txtObjetivoCurso.Text = datD[7];
                txtMaterial.Text = datD[4];
                txtCertificacion.Text = datD[0];
                txtInversion.Text = datD[3];
                txtMetodologia.Text = datD[5];
                //txtCodigoCurso.Enabled = false;


            }





        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {


            String COD = txtCodigoCurso.Text;
            String NOM = txtNombreCurso.Text;
            String DUR = txtDuracion.Text;
            String OBJ = txtObjetivoCurso.Text;
            String MAT = txtMaterial.Text;
            String CER = txtCertificacion.Text;
            String INV = txtInversion.Text;
            String MET = txtMetodologia.Text;

            if (COD == "" || NOM == "" || DUR == "" || OBJ == "" || MAT == "" || CER == "" || INV == "" || MET == "")
            {
                ClientScript.RegisterStartupScript(GetType(), "MostrarMensaje", "Mensaje();", true);

            }
            else
            {

                DATA.Curso curso = new DATA.Curso
                {
                    CodigoCurso = COD,
                    Certificacion = CER,
                    Duracion = DUR,
                    Inversion = INV,
                    MaterialDidactico = MAT,
                    Metodologia = MET,
                    NombreCurso = NOM,
                    ObjetivoCurso = OBJ,
                    Estado = true

                };


                cur.ActualizarCurso(curso);
                //Session["Inf"] = "";

                //var C = Convert.ToString(Session["Inf"]);
                Response.Redirect("Curso.aspx");




            }
        }
    }
}