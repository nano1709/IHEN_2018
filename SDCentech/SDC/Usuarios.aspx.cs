using SDC.BLL.Interface;
using SDC.BLL.Metodos;
using System;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace SDC
{
    public partial class Usuarios : System.Web.UI.Page
    {
        private IUsuarios usu;
        public string Fila;


        public Usuarios()
        {
            usu = new MUsuarios();


        }



        protected void Page_Load(object sender, EventArgs e)
        {
            String deleteid = Request.QueryString["deleteid"];
            var listus = usu.ListUser().Where(x => x.Estado == true).ToList();



            if (deleteid != null)
            {
                EliminarUusario(deleteid);
            }




            StringBuilder sb = new StringBuilder();


            foreach (var item in listus)
            {
                sb.Append("<TR>");
                sb.Append("<TD>");
                sb.Append(item.IDUser);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.NombreUsuario);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Email);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append(item.Rol);
                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append("<button class='btn btn-warning btn-sm editar'  type='button'>View/Edit</button>");

                sb.Append("</TD>");
                sb.Append("<TD>");
                sb.Append("<button class='btn btn-danger btn-sm borrar'  type='button'>Delete</button>");

                sb.Append("</TD>");
                sb.Append("</TR>");

                Fila = sb.ToString();


            }



        }
        public void EliminarUusario(String Key)

        {


            //usu.DeleteUser(Convert.ToInt32(Key));

        }

        protected void AddUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroUsuarios.aspx");
        }
    }
}
