using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;

namespace SDC
{
    public partial class RegistroEstudiante : System.Web.UI.Page
    {

        private IEstudiante estu;
        private ITecnico tec;

        public RegistroEstudiante()
        {
            estu = new MEstudiante();
            tec = new MTecnico();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var Tecnicos = tec.ListaTecnico();
            var sedes = estu.ListaSede();

            foreach (var item in Tecnicos)
            {
                ddlCarreraTecnica.Items.Insert(0, item.NombreTecnico);
            }

            foreach (var item in sedes)
            {
                ddlSede.Items.Insert(Convert.ToInt32(item.IdSede), item.NombreSede.ToString());
            }
            ddlSede.DataBind();
            ddlCarreraTecnica.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedula.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string fechaIngreso = txtFechaIngreso.Text;
            string carrera = ddlCarreraTecnica.SelectedItem.Value;
            string fechaNacimiento = txtFechaNacimiento.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string genero = ddlGenero.SelectedItem.Value;
            string telMovil = txtTelefonoMovil.Text;
            string telDomicilio = txtTelefonoDomicilio.Text;
            string correo = txtcorreo.Text;
            string refPersonal = txtReferencia.Text;
            string telReferencia = txtReferencia.Text;
            string provincia = ddlProvincia.SelectedItem.Value;
            string canton = txtCanton.Text;
            string distrito = txtDistrito.Text;
            string domexacto = txtDomicilio.Text;
            int idSede = Convert.ToInt32(ddlSede.SelectedIndex);


            GuardarEstudiante(cedula, nombre, apellido, fechaIngreso, carrera, fechaNacimiento, edad, genero, telMovil, telDomicilio, correo,
                            refPersonal, telReferencia, provincia, canton, distrito, domexacto, idSede);
            Response.Redirect("Estudiante.aspx?exito=" + 2 + "&nombreEstuAgre=" + nombre + " " + apellido);
        }

        protected void GuardarEstudiante(int cedula, string nombre, string apellido, string fechaIngreso, string carreraTecnica,
                        string fechaNacimiento, int edad, string genero, string telMovil, string teleDomicilio,
                        string correoElectronico, string refePersonal, string teleReferencia, string provincia,
                        string canton, string distrito, string domiExacto, int idSede)
        {
            try
            {
                DATA.Estudiante estudiante = new DATA.Estudiante
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    FechaIngreso = fechaIngreso,
                    CarreraTecnica = carreraTecnica,
                    FechaNacimiento = fechaNacimiento,
                    Edad = edad,
                    Genero = genero,
                    TelefonoMovil = telMovil,
                    TelefonoDomicilio = teleDomicilio,
                    CorreoElectronico = correoElectronico,
                    ReferenciaPersonal = refePersonal,
                    TelefonoReferencia = teleReferencia,
                    Provincia = provincia,
                    Canton = canton,
                    Distrito = distrito,
                    DomicilioExacto = domiExacto,
                    IdSede = idSede,
                    Estado = 1
                };

                estu.RegistroEstudiante(estudiante);
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx?error=" + ex);
            }

        }
    }
}