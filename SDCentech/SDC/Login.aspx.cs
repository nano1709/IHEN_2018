using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDC.DAL.Interface;
using SDC.BLL.Interfaces;

namespace SDC
{
    public partial class Login1 : System.Web.UI.Page
    {
        public string ErrorM = "123";

        IUsuarios usu;

        public Login1()
        {
            usu = new BLL.Metodos.MUsuarios();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            String mer = Convert.ToString(Session["Error"]);

            if (mer != "")
            {
                ErrorM = "1234";

            }





        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text != "" && txtPass.Text != "")
            {

                BLL.Seguridad seg = new BLL.Seguridad();

                string pass = seg.Encriptar(txtPass.Text);

                var usuario = usu.LoginUser(txtUser.Text, pass);



                if (usuario != null)
                {
                    Session["UserId"] = usuario.IDUser;
                    Session["UserName"] = usuario.NombreUsuario;
                    Session["Roll"] = usuario.Rol;
                    Response.Redirect("Menu.aspx", false);

                }
                else
                {
                    Session["Error"] = "Hola";

                    h1id.InnerText = seg.Encriptar(txtPass.Text);
                    //Response.Redirect("Login.aspx", false);

                }

            }

            Response.Redirect("Menu.aspx");

        }
    }
}