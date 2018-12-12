using SDC.BLL.Interfaces;
using SDC.BLL.Metodos;
using System;
using System.Linq;

namespace SDC
{
    public partial class ModificarEstudiante : System.Web.UI.Page
    {

        private IEstudiante estu;
        private ITecnico tec;

        public ModificarEstudiante()
        {
            estu = new MEstudiante();
            tec = new MTecnico();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.Seguridad seg = new BLL.Seguridad();


                var query = Request.QueryString["editid"];
                var queryReplace = query.Replace(' ','+');
                var editid = seg.Decriptar(queryReplace); 

                var lista = editid.Split('§');
                string cedula = lista[0];
                string nombre = lista[1];
                string apellido = lista[2];
                string fechaIngreo = lista[3];
                string carreraTecnica = lista[4];
                string fechaNacimiento = lista[5];
                string genero = lista[6];
                string edad = lista[16];
                string telefonoMovil = lista[7];
                string telefonoDomicilio = lista[8];
                string correoElectronico = lista[9];
                string referenciaPersonal = lista[10];
                string telefonoReferencia = lista[11];
                string provincia = lista[12];
                string distrito = lista[13];
                string canton = lista[14];
                string domicilioExacto = lista[15];
                string idSede = lista[17];
                string ModIngreso = lista[18];

                var tecnicos = tec.ListaTecnico();
                var sedes = estu.ListaSede();

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
                    txtApellido.Text = apellido;
                    txtFechaIngreso.Text = fechaIngreo;
                    ddlCarreraTecnica.Items.FindByValue(carreraTecnica.Trim()).Selected = true;
                    txtFechaNacimiento.Text = fechaNacimiento;
                    txtEdad.Text = edad;
                    ddlGenero.Items.FindByValue(genero.Trim()).Selected = true;
                    txtTelefonoMovil.Text = telefonoMovil;
                    txtTelefonoDomicilio.Text = telefonoDomicilio;
                    txtcorreo.Text = correoElectronico;
                    txtReferencia.Text = referenciaPersonal;
                    txtTelReferencia.Text = telefonoReferencia;
                    ddlProvincia.Text = provincia;
                    txtCanton.Text = canton;
                    txtDistrito.Text = distrito;
                    txtDomicilio.Text = domicilioExacto;
                    txtModIngreso.Text = ModIngreso;

                    foreach (var item in estu.ListaEstudiante().Where(x => x.Cedula == Convert.ToInt32(cedula)))
                    {
                        foreach (var item1 in estu.ListaSede())
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
            string telReferencia = txtTelReferencia.Text;
            string provincia = ddlProvincia.SelectedItem.Value;
            string canton = txtCanton.Text;
            string distrito = txtDistrito.Text;
            string domexacto = txtDomicilio.Text;
            int idSede = Convert.ToInt32(ddlSede.SelectedIndex);
            string modIngreso = txtModIngreso.Text;

            EditarEstudiante(cedula, nombre, apellido, fechaIngreso, carrera, fechaNacimiento, edad, genero, telMovil, telDomicilio, correo,
                            refPersonal, telReferencia, provincia, canton, distrito, domexacto, idSede, modIngreso);
            Response.Redirect("Estudiante.aspx?exito=" + 1 + "&nombreEstuModi=" + nombre + " " + apellido);
        }

        protected void EditarEstudiante(int cedula, string nombre, string apellido, string fechaIngreso, string carreraTecnica,
                        string fechaNacimiento, int edad, string genero, string telMovil, string teleDomicilio,
                        string correoElectronico, string refePersonal, string teleReferencia, string provincia,
                        string canton, string distrito, string domiExacto, int idSede, string modIngreso)
        {
            try
            {

                var select = estu.SeleccionarEstudianteCedula(cedula);
                select.Cedula = cedula;
                select.Nombre = nombre;
                select.Apellido = apellido;
                select.FechaIngreso = fechaIngreso;
                select.CarreraTecnica = carreraTecnica;
                select.FechaNacimiento = fechaNacimiento;
                select.Edad = edad;
                select.Genero = genero;
                select.TelefonoMovil = telMovil;
                select.TelefonoDomicilio = teleDomicilio;
                select.CorreoElectronico = correoElectronico;
                select.ReferenciaPersonal = refePersonal;
                select.TelefonoReferencia = teleReferencia;
                select.Provincia = provincia;
                select.Canton = canton;
                select.Distrito = distrito;
                select.DomicilioExacto = domiExacto;
                select.IdSede = idSede;
                select.ModalidadIngreso = modIngreso;

                estu.ActualizarEstudiante(select);
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}