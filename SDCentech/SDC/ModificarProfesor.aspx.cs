using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;

namespace SDC
{
    public partial class ModificarProfesor : System.Web.UI.Page
    {

        private IProfesor profe;
        private ITecnico tec;

        public ModificarProfesor()
        {
            profe = new MProfesor();
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
                string cedula = lista[0];
                string canton = lista[1];
                string carrera = lista[2];
                string correo = lista[3];
                string direccionTrabajo = lista[4];
                string distrito = lista[5];
                string domexacto = lista[6];
                string edad = lista[7];
                string fechaFinalizacion = lista[8];
                string fechaIngreso = lista[9];
                string fechaInicio = lista[10];
                string fechaNacimiento = lista[11];
                string genero = lista[12];
                string gradoAcademico = lista[13];
                string institucion = lista[14];
                string lugarTrabajo = lista[15];
                string nombre = lista[16];
                string nombreBanco = lista[17];
                string numeroCuenta = lista[18];
                string provincia = lista[19];
                string telDomicilio = lista[20];
                string telMovil = lista[21];
                string telefonoTrabajo = lista[22];
                string idSede = lista[23];

                var tecnicos = tec.ListaTecnico();
                var sedes = profe.ListaSede();

                if (editid != null || cedula != null)
                {
                    foreach (var item in tecnicos)
                    {
                        ddlCarreraTecnica.Items.Insert(0, item.NombreTecnico);
                    }
                    ddlCarreraTecnica.DataBind();

                    foreach (var item in sedes)
                    {
                        ddlSede.Items.Insert(Convert.ToInt32(item.IdSede), item.NombreSede.ToString());
                    }
                    ddlSede.DataBind();

                    txtCedula.Text = cedula;
                    txtNombre.Text = nombre;
                    txtFechaIngreso.Text = fechaIngreso;
                    ddlCarreraTecnica.Items.FindByValue(carrera.Trim()).Selected = true;
                    txtFechaNacimiento.Text = fechaNacimiento;
                    txtEdad.Text = edad;
                    ddlGenero.Items.FindByValue(genero.Trim()).Selected = true;
                    txtTelefonoMovil.Text = telMovil;
                    txtTelefonoDomicilio.Text = telDomicilio;
                    txtcorreo.Text = correo;
                    txtCanton.Text = canton;
                    txtxDistrito.Text = distrito;
                    txtDomicilio.Text = domexacto;
                    ddlProvincia.Text = provincia;
                    txtNumeroCuenta.Text = numeroCuenta;
                    txtBanco.Text = nombreBanco;
                    txtLugar.Text = lugarTrabajo;
                    txtTelefonoTrabajo.Text = telefonoTrabajo;
                    txtDireccionTrabajo.Text = direccionTrabajo;
                    txtFechaFinalizacion.Text = fechaFinalizacion;
                    txtGradoAcademico.Text = gradoAcademico;
                    txtInstitución.Text = institucion;
                    txtFechaInicioTrabajo.Text = fechaInicio;

                    foreach (var item in profe.ListaProfesor().Where(x => x.Cedula == Convert.ToInt32(cedula)))
                    {
                        foreach (var item1 in profe.ListaSede())
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
            string provincia = ddlProvincia.SelectedItem.Value;
            int numeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text);
            string nombreBanco = txtBanco.Text;
            string lugarTrabajo = txtLugar.Text;
            int telefonoTrabajo = Convert.ToInt32(txtTelefonoTrabajo.Text);
            string direccionTrabajo = txtDireccionTrabajo.Text;
            string fechaFinalizacion = txtFechaFinalizacion.Text;
            string gradoAcademico = txtGradoAcademico.Text;
            string institucion = txtInstitución.Text;
            string fechaInicio = txtFechaInicioTrabajo.Text;

            EditarProfesor(cedula, canton, carrera, correo, direccionTrabajo,
                                      distrito, domexacto, edad, fechaFinalizacion, fechaIngreso,
                                      fechaInicio, fechaNacimiento, genero, gradoAcademico,
                                       institucion, lugarTrabajo, nombre, nombreBanco, numeroCuenta,
                                         provincia, telDomicilio, telMovil, telefonoTrabajo,
                                       idSede);
            Response.Redirect("Profesor.aspx?exito=" + 2 + "&nombreProfeModi=" + nombre + " ");
        }

        protected void EditarProfesor(int cedula, string canton, string carrera, string correo, string direccionTrabajo,
                                string distrito, string domexacto, int edad, string fechaFinalizacion, string fechaIngreso,
                                string fechaInicio, string fechaNacimiento, string genero, string gradoAcademico,
                                 string institucion, string lugarTrabajo, string nombre, string nombreBanco, int numeroCuenta,
                                   string provincia, int telDomicilio, int telMovil, int telefonoTrabajo,
                                 int idSede)
        {
            try
            {

                var select = profe.SeleccionarProfesorCedula(cedula);
                select.Cedula = cedula;
                select.Canton = canton;
                select.CarreraTecnica = carrera;
                select.CorreoElectronico = correo;
                select.DireccionTrabajo = direccionTrabajo;
                select.Distrito = distrito;
                select.DomicilioExacto = domexacto;
                select.Edad = edad;
                select.FechaFinalizacion = fechaFinalizacion;
                select.FechaIngreso = fechaIngreso;
                select.FechaInicio = fechaInicio;
                select.FechaNacimiento = fechaNacimiento;
                select.Genero = genero;
                select.GradoAcademico = gradoAcademico;
                select.Institucion = institucion;
                select.LugarTrabajo = lugarTrabajo;
                select.Nombre = nombre;
                select.NombreBanco = nombreBanco;
                select.NumeroCuenta = numeroCuenta;
                select.Provincia = provincia;
                select.TelefonoDomicilio = telDomicilio;
                select.TelefonoMovil = telMovil;
                select.TelefonoTrabajo = telefonoTrabajo;
                select.IdSede = idSede;

                profe.ActualizarProfesor(select);
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
