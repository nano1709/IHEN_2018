using SDC.BLL;
using SDC.BLL.Interface;
using SDC.BLL.Metodos;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace SDC
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        private IUsuarios usuarios;


        public RegistroUsuarios()
        {
            usuarios = new MUsuarios();
        }

        protected void Page_Load(object sender, EventArgs e)
        {







        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var NombreUsuario = txtNU.Text;
            var Rol = txtNombreCurso.Text;
            var Email = txtCE.Text;
            var Password = txtContraseña.Text;
            var code = "";
            var IDUser = "";



            try
            {

                var listU = usuarios.ListUser();

                var list = listU.Select(x =>
             new
             {
                 x.IDUser
             }).ToList();
                var ID = 1;

                if (list.Count > 0)
                {
                    var id = list.Last();
                    ID = id.IDUser + 1;
                }


                if (NombreUsuario != "" && Rol != "" && Email != "" && Password != "")
                {



                    Seguridad seg = new Seguridad();

                    string pass = seg.Encriptar(Password);

                    DATA.Usuarios usuarioD = new DATA.Usuarios
                    {
                        code = code,
                        Email = Email,
                        Password = pass,
                        Rol = Convert.ToInt32(Rol),
                        Estado = true,
                        IDUser = Convert.ToInt32(ID),
                        NombreUsuario = NombreUsuario
                    };

                    usuarios.InsertUser(usuarioD);
                    Response.Redirect("Usuarios.aspx");





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
            Response.Redirect("Usuarios.aspx");

        }
    }
}