using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;

namespace SDC
{
    public partial class ModificacionModulo : System.Web.UI.Page
    {
        private IModulo mod;

        public ModificacionModulo()
        {
            mod = new MModulo();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.Seguridad seg = new BLL.Seguridad();


                var query = Request.QueryString["editid"];
                var queryReplace = query.Replace(' ', '+');
                var editid = seg.Decriptar(queryReplace);

                var lista = editid.Split('§');
                string codModulo = lista[0];
                string nombre = lista[1];
                string creditos = lista[2];
                string duracion = lista[3];
                string idSede = lista[4];


                var sedes = mod.ListaSede();

                if (editid != null || codModulo != null)
                {

                    foreach (var item in sedes)
                    {
                        ddlSede.Items.Insert(Convert.ToInt32(item.IdSede), item.NombreSede.ToString());
                    }
                    ddlSede.DataBind();

                    txtCodigo.Text = codModulo;
                    txtNombreModulo.Text = nombre;
                    txtCreditos.Text = creditos;
                    txtDuracion.Text = duracion;


                    foreach (var item in mod.ListaModulo().Where(x => x.CodigoModulo == codModulo))
                    {
                        foreach (var item1 in mod.ListaSede())
                        {
                            if (item.IdSede == item1.IdSede)
                            {
                                ddlSede.SelectedValue = item1.NombreSede;
                            }
                        }
                    }
                }
                else
                {
                    Response.Redirect("Error.aspx");
                }
            }



        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string codModulo = txtCodigo.Text;
            string nombre = txtNombreModulo.Text;
            int creditos = Convert.ToInt32(txtCreditos.Text);
            string duracion = txtDuracion.Text;
            int idSede = Convert.ToInt32(ddlSede.SelectedIndex);


            EditarModulo(codModulo, nombre, creditos, duracion, idSede);
            Response.Redirect("Modulo.aspx?exito=" + 1 + "&nombreModModi=" + codModulo + " " + nombre);

        }

        protected void EditarModulo(string codModulo, string nombre, int creditos, string duracion, int idSede)
        {
            try
            {

                var select = mod.SeleccionarModuloPorCodigo(codModulo);
                select.CodigoModulo = codModulo.ToString();
                select.NombreModulo = nombre;
                select.Creditos = creditos;
                select.Duracion = duracion;
                select.IdSede = idSede;

                mod.ActualizarModulo(select);
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
