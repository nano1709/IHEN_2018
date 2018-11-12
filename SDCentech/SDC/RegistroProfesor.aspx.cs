using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;

namespace SDC
{
    public partial class RegistroProfesor : System.Web.UI.Page
    {
        private IProfesor profe;
        private ITecnico tec;

        public RegistroProfesor()
        {
            profe = new MProfesor();
            tec = new MTecnico();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            var Tecnicos = tec.ListaTecnico();
            var sedes = profe.ListaSede();
            var i = 0;
            foreach (var item in Tecnicos)
            {
                ddlCarreraTecnica.Items.Insert(i, item.NombreTecnico);
                i++;
            }

            foreach (var item in sedes)
            {
                ddlSede.Items.Insert(Convert.ToInt32(item.IdSede), item.NombreSede);
            }
            ddlSede.DataBind();
            ddlCarreraTecnica.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            int cedula = Convert.ToInt32(txtCedula.Text);
            string nombre = txtNombre.Text;
            string fechaIngreso = txtFechaIngreso.Text;
            string carrera = ddlCarreraTecnica.SelectedItem.Value;
            string fechaNacimiento = txtFechaNacimiento.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string genero = ddlGenero.SelectedItem.Value;
            int telMovil = Convert.ToInt32(txtTelefonoMovil.Text);
            int telDomicilio = Convert.ToInt32(txtTelefonoDomicilio.Text);
            string correo = txtcorreo.Text;
            string canton = txtCanton.Text;
            string distrito = txtxDistrito.Text;
            string domexacto = txtDomicilio.Text;
            int idSede = Convert.ToInt32(ddlSede.SelectedIndex);
            string provincia = txtProvincia.Text;
            int numeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text);
            string nombreBanco = txtBanco.Text;
            string lugarTrabajo = txtLugar.Text;
            int telefonoTrabajo = Convert.ToInt32(txtTelefonoTrabajo.Text);
            string direccionTrabajo = txtDireccionTrabajo.Text;
            string fechaFinalizacion = txtFechaFinalizacion.Text;
            string gradoAcademico = txtGradoAcademico.Text;
            string institucion = txtInstitución.Text;
            string fechaInicio = txtFechaInicioTrabajo.Text;

            GuardarProfesor(cedula, canton, carrera, correo, direccionTrabajo,
                                      distrito, domexacto, edad, fechaFinalizacion, fechaIngreso,
                                      fechaInicio, fechaNacimiento, genero, gradoAcademico,
                                       institucion, lugarTrabajo, nombre, nombreBanco, numeroCuenta,
                                         provincia, telDomicilio, telMovil, telefonoTrabajo,
                                       idSede);
            Response.Redirect("Profesor.aspx?exito=" + 2 + "&nombreProfeAgre=" + nombre + " ");

        }

        protected void GuardarProfesor(int cedula, string canton, string carrera, string correo, string direccionTrabajo,
                                string distrito, string domexacto, int edad, string fechaFinalizacion, string fechaIngreso,
                                string fechaInicio, string fechaNacimiento, string genero, string gradoAcademico,
                                 string institucion, string lugarTrabajo, string nombre, string nombreBanco, int numeroCuenta,
                                   string provincia, int telDomicilio, int telMovil, int telefonoTrabajo,
                                 int idSede)
        {
            try
            {
                DATA.Profesor profesor = new DATA.Profesor
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    CarreraTecnica = carrera,
                    FechaIngreso = fechaIngreso,
                    CorreoElectronico = correo,
                    DireccionTrabajo = direccionTrabajo,
                    FechaNacimiento = fechaNacimiento,
                    Edad = edad,
                    FechaFinalizacion = fechaFinalizacion,
                    FechaInicio = fechaInicio,
                    DomicilioExacto = domexacto,
                    TelefonoMovil = telMovil,
                    TelefonoDomicilio = telDomicilio,
                    Genero = genero,
                    Institucion = institucion,
                    GradoAcademico = gradoAcademico,
                    Provincia = provincia,
                    Canton = canton,
                    Distrito = distrito,
                    LugarTrabajo = lugarTrabajo,
                    NombreBanco = nombreBanco,
                    NumeroCuenta = numeroCuenta,
                    TelefonoTrabajo = telefonoTrabajo,
                    IdSede = idSede,
                    Estado = 1
                };

                profe.RegistroProfesor(profesor);
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx?error=" + ex);
            }

        }

    }
}
