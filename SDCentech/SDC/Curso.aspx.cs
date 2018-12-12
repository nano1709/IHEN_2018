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

            String deleteid = Request.QueryString["deleteid"];
            var listCur = cur.ListaCurso().Where(x => x.Estado == true).ToList();

            if (deleteid != null)
            {
                EliminarCurso(deleteid);
            }



            StringBuilder sb = new StringBuilder();
            foreach (var item in listCur)
            {


                sb.Append("<TR>");
                sb.Append("<TD>");
                sb.Append(item.CodigoCurso);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.NombreCurso);

                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Duracion);

                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.ObjetivoCurso);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.MaterialDidactico);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.Certificacion);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.Inversion);
                sb.Append("</TD>");

                sb.Append("<TD>");
                sb.Append(item.Metodologia);
                sb.Append("</TD>");


                sb.Append("<TD>");

                var Cer = (item.Certificacion).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Cod = (item.CodigoCurso).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Dur = (item.Duracion).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Inv = (item.Inversion).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Mat = (item.MaterialDidactico).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Met = (item.Metodologia).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Nom = (item.NombreCurso).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Obj = (item.ObjetivoCurso).Replace(" ", "Ơ").Replace("-", "ƶ");
                var Sed = item.IdSede;



                var datos = Cer + "ὣ" + Cod + "ὣ" + Dur + "ὣ" + Inv + "ὣ" +
                    Mat + "ὣ" + Met + "ὣ" + Nom + "ὣ" + Obj + "ὣ" + Sed;
                BLL.Seguridad seg = new BLL.Seguridad();
                string newDatos = seg.Encriptar(datos);

                newDatos = newDatos.Replace("+", "Ɲ");

                sb.Append("<button class='btn btn-info editar' value = '" + newDatos + "' type='button'>Ver</button>");
                sb.Append("</TD>");

                sb.Append("<TD>");

                sb.Append("<button class='btn btn-danger borrar' value = '" + item.CodigoCurso + "' type='button'>Eliminar</button>");

                sb.Append("</TD>");


                /*sb.Append("<TD>");

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
            Response.Redirect("RegistroCursos.aspx");
        }



        public void EliminarCurso(String Key)

        {
            DATA.Curso curso = new DATA.Curso
            {
                CodigoCurso = Key,
                Estado = false
            };

            cur.EliminarCursp(curso);

        }

    }
}