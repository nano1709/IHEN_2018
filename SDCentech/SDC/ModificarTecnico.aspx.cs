using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;

namespace SDC
{
    public partial class ModificarTecnico : System.Web.UI.Page
    {
        private ITecnico tec;

        public ModificarTecnico()
        {
            tec = new MTecnico();
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
                string codTecnico = lista[0];
                string nombre = lista[1];
                string perfil = lista[2];
                string duracion = lista[3];
                string practica = lista[4];
                string requisitos = lista[5];

                if (editid != null || codTecnico != null)
                {
                    txtCodigoTecnico.Text = codTecnico;
                    txtPerfilOcupacional.Text = perfil;
                    txtNombreTecnico.Text = nombre;
                    txtDuracion.Text = duracion;
                    txtPracticas.Text = practica;
                    txtRequisitos.Text = requisitos;
                }
                else
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string codTecnico = txtCodigoTecnico.Text;
            string nombre = txtNombreTecnico.Text;
            string perfil = txtPerfilOcupacional.Text;
            string duracion = txtDuracion.Text;
            string practica = txtPracticas.Text;
            string requisitos = txtRequisitos.Text;

            EditarTecnico(codTecnico, nombre, perfil, duracion, practica, requisitos);
            Response.Redirect("Tecnico.aspx?exito=" + 1 + "&nombreTecModi=" + codTecnico + " " + nombre);


        }

        protected void EditarTecnico(string codTecnioc, string nombre, string perfil, string duracion, string practica, string requisitos)
        {
            try
            {

                var select = tec.SeleccionarTecnicoPorCodigo(codTecnioc);
                select.CodigoTecnico = codTecnioc.ToString();
                select.NombreTecnico = nombre;
                select.PerfilOcupacional = perfil;
                select.Duracion = duracion;
                select.PracticaProf = practica;
                select.Requisitos = requisitos;

                tec.ActualizarTecnico(select);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}