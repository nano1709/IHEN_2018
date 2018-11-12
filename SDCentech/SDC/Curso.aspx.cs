using SDC.BLL.Interfaces;
using SDC.BLL.Metotdos;
using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;


namespace SDC
{
    public partial class Curso : System.Web.UI.Page
    {


        private ICurso cur;
        public string Fila;


        public Curso()
        {
            cur = new MCurso();


        }


        protected void Page_Load(object sender, EventArgs e)
        {
            var listCur = cur.ListaCurso().Where(x => x.Estado == true).ToList();


            StringBuilder sb = new StringBuilder();
            foreach (var item in listCur)
            {


                sb.Append("<TR>");
                sb.Append("<TD>");
                sb.Append(item.CodigoCurso);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Certificacion);

                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Duracion);

                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Inversion);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.MaterialDidactico);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.Metodologia);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.NombreCurso);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.ObjetivoCurso);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append("</TD>");


                /*sb.Append("<TD>");

                var datos = item.Certificacion + "ὣ" + item.CodigoCurso + "ὣ" + item.Duracion + "ὣ" + item.Inversion + "ὣ" +
                    item.MaterialDidactico + "ὣ" + item.Metodologia + "ὣ" + item.NombreCurso + "ὣ" + item.ObjetivoCurso;
                Seguridad seg = new Seguridad();
                string newDatos = seg.Encriptar(datos);
                sb.Append("<button class =' btn btn-warning btn-sm editar'  type='button valule '" + newDatos + "'>Ver/Editar</button> ");
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append("<button class =' btn btn-danger btn-sm borrar'  type='button valule '" + newDatos + "'>Deshabilitar</button> ");
                sb.Append("</TD>");*/

                sb.Append("</TR>");

                Fila = sb.ToString();

            }


        }

        protected void AddCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroCurso.aspx");
        }
    }
}