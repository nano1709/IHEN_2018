using System;
using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;

namespace SDC
{
    public partial class RegistroTecnicos : System.Web.UI.Page
    {

        private ITecnico tec;

        public RegistroTecnicos()
        {

            tec = new MTecnico();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigoTecnico = txtCodigoTecnico.Text;
            string nombre = txtNombreTecnico.Text;
            string perfilOcupacional = txtPerfilOcupacional.Text;
            string duracion = txtDuracion.Text;
            string practicasProfesionales = txtPracticas.Text;
            string requisitos = txtRequisitos.Text;



            GuardarTecnico(codigoTecnico, nombre, perfilOcupacional, duracion, practicasProfesionales,
                                     requisitos);
            Response.Redirect("Tecnico.aspx?exito=" + 2 + "&nombreTecAgre=" + codigoTecnico + " " + nombre);
        }


        protected void GuardarTecnico(string codigoTecnico, string nombre, string perfilOcupacional, string duracion,
            string practicasProfesionales, string requisitos)
        {
            try
            {
                DATA.Tecnico tecnico = new DATA.Tecnico
                {
                    CodigoTecnico = codigoTecnico,
                    NombreTecnico = nombre,
                    PerfilOcupacional = perfilOcupacional,
                    Duracion = duracion,
                    PracticaProf = practicasProfesionales,
                    Requisitos = requisitos,
                    Estado = 1
                };

                tec.RegistroTecnico(tecnico);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}