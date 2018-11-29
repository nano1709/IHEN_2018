<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="ModificarEstudiante.aspx.cs" Inherits="SDC.ModificarEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 278px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>


    <div class="product-screen-1 wow fadeInLeft" runat="server" data-wow-delay="0.1s" data-wow-duration="0.1s">
        <div id="divClientes" class="form-group" runat="server" visible="true">

            <h3 style="color: #308ED5">Modificar Curso</h3>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblFechaIngreso" runat="server" Text="Fecha de ingreso: " ForeColor="#308ED5"></asp:Label>

                        <%-- Poner textmode=calendar en FEchas--%>
                        <asp:TextBox ID="txtFechaIngreso" runat="server" TextMode="Date" class="form-control" Width="320px">
                        </asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFechaIngreso" runat="server"
                            ControlToValidate="txtFechaIngreso"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCarrera" runat="server" Text="Carrera técnica: " ForeColor="#308ED5"></asp:Label>
                        <%--<asp:TextBox ID="txtCarreraTecnica" runat="server" placeholder="Carrera técnica" class="form-control" Width="320px"></asp:TextBox>--%>
                        <asp:DropDownList ID="ddlCarreraTecnica" runat="server" placeholder="Carrera técnica" class="form-control" Width="320px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="ddlCarreraTecnica"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Datos del Estudiante</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control" Width="320px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvNombre" runat="server"
                            ControlToValidate="txtNombre"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblApellido" runat="server" Text="Apellido: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtApellido" runat="server" placeholder="Apellido" class="form-control" Width="320px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvApellido" runat="server"
                            ControlToValidate="txtApellido"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCedula" runat="server" Text="Cédula: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCedula" runat="server" TextMode="Number" placeholder="Cédula" class="form-control" Width="320px" ReadOnly="true"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvCedula" runat="server"
                            ControlToValidate="txtCedula"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date" class="form-control" Width="320px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvFechaNacimiento" runat="server"
                            ControlToValidate="txtFechaNacimiento"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </tr>

                <tr>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label2" runat="server" Text="Edad: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtEdad" runat="server" TextMode="Number" placeholder="Edad" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label9" runat="server" Text="Genero: " ForeColor="#308ED5"></asp:Label>
                        <asp:DropDownList ID="ddlGenero" runat="server" placeholder="Género" class="form-control" Width="320px">
                            <asp:ListItem>Mujer</asp:ListItem>
                            <asp:ListItem>Hombre</asp:ListItem>
                        </asp:DropDownList>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label3" runat="server" Text="Teléfono móvil: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoMovil" runat="server" TextMode="Number" placeholder="Teléfono móvil" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label4" runat="server" Text="Teléfono domicilio: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoDomicilio" runat="server" TextMode="Number" placeholder="Teléfono domicilio" class="form-control" Width="320px"></asp:TextBox>
                </tr>
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label5" runat="server" Text="Correo electrónico: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtcorreo" runat="server" placeholder="Correo electrónico" TextMode="email" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label6" runat="server" Text="Provincia: " ForeColor="#308ED5"></asp:Label>
                        <asp:DropDownList ID="ddlProvincia" runat="server" placeholder="Provincia" class="form-control" Width="320px">
                            <asp:ListItem>Cartago</asp:ListItem>
                            <asp:ListItem>San José</asp:ListItem>
                            <asp:ListItem>Heredia</asp:ListItem>
                            <asp:ListItem>Alajuela</asp:ListItem>
                            <asp:ListItem>Puntarenas</asp:ListItem>
                            <asp:ListItem>Guancaste</asp:ListItem>
                            <asp:ListItem>Limon</asp:ListItem>
                        </asp:DropDownList>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label7" runat="server" Text="Cantón: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCanton" runat="server" placeholder="Cantón" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label8" runat="server" Text="Distrito: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDistrito" runat="server" placeholder="Distrito" class="form-control" Width="320px">Mote </asp:TextBox>
                </tr>
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label13" runat="server" Text="Domicilio exacto: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDomicilio" runat="server" placeholder="Domicilio exacto" TextMode="MultiLine" class="form-control" Width="305"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label10" runat="server" Text="Referencia Personal: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtReferencia" runat="server" placeholder="Referencia Personal" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label11" runat="server" Text="Teléfono referencia: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelReferencia" runat="server" TextMode="Number" placeholder="Teléfono Referencia" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Datos Sede</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label12" runat="server" Text="Id Sede: " ForeColor="#308ED5"></asp:Label>
                        <asp:DropDownList ID="ddlSede" runat="server" placeholder="Sede" class="form-control" Width="320px"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="ddlSede"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;"></td>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;"></td>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;"></td>
                </tr>
            </table>
            <br />
            <div class="col-lg-12 text-center">
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" class="btn btn-form"
                    Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" OnClick="btnModificar_Click" />
            </div>
            <br />
        </div>
    </div>



</asp:Content>

