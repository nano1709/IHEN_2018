<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="ModificarProfesor.aspx.cs" Inherits="SDC.ModificarProfesor" %>

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

            <h3 style="color: #308ED5">Modificación de profesores</h3>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblFechaIngreso" runat="server" Text="Fecha de ingreso: " ForeColor="#308ED5"></asp:Label>
                        <%-- Poner textmode date en fecha de ingreso  --%>
                        <asp:TextBox ID="txtFechaIngreso" runat="server"  class="form-control" Width="320px" Text="15/03/2014"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblTecImpartido" runat="server" Text="Técnico Impartido: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTecImpartido" runat="server" placeholder="Técnico Impartido" class="form-control" Width="320px">Hotelería</asp:TextBox>
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Datos personales</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" placeholder="Nombre" class="form-control" Width="320px" Text="Harry"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCedula" runat="server" Text="Cédula: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCedula" runat="server" TextMode="Number" placeholder="Cédula" class="form-control" Width="320px" ReadOnly="True" Text="116920355"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" class="form-control" Width="320px" Text="20/11/1997"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label2" runat="server" Text="Edad: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtEdad" runat="server" TextMode="Number" placeholder="Edad" class="form-control" Width="305px" Text="21"></asp:TextBox>
                </tr>

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label3" runat="server" Text="Teléfono móvil: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoMovil" runat="server" TextMode="Number" placeholder="Teléfono móvil" class="form-control" Width="320px" Text="86763562"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label4" runat="server" Text="Teléfono domicilio: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoDomicilio" runat="server" TextMode="Number" placeholder="Teléfono domicilio" class="form-control" Width="320px" Text="25549762"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label5" runat="server" Text="Correo electrónico: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtcorreo" runat="server" placeholder="Correo electrónico" TextMode="email" class="form-control" Width="320px" Text="harry@gmail.com"></asp:TextBox>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
                <tr>
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
                        <asp:TextBox ID="txtCanton" runat="server" placeholder="Cantón" class="form-control" Width="320px" Text="Oriental"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label8" runat="server" Text="Distrito: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtxDistrito" runat="server" placeholder="Distrito" class="form-control" Width="320px" Text="Monte Limar"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label13" runat="server" Text="Domicilio exacto: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDomicilio" runat="server" placeholder="Domicilio exacto" TextMode="MultiLine" class="form-control" Width="305" Text="100 metros sur del Colegios San Luis Gonzaga, 25 este"></asp:TextBox>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Cuenta bancaria</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label10" runat="server" Text="Número de cuenta: " ForeColor="#308ED5"></asp:Label>
                        <%-- Poner textmode nujmber en txtnumerocuenta --%>
                        <asp:TextBox ID="txtNumeroCuenta" runat="server"  placeholder="Número de cuenta" class="form-control" Width="320px">9357 2310 18 6903213835</asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label11" runat="server" Text="Banco: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtBanco" runat="server" placeholder="Banco" class="form-control" Width="320px" Text="BCR"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Lugar de trabajo</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label12" runat="server" Text="Teléfono: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoTrabajo" runat="server" TextMode="number" placeholder="Teléfono trabajo" class="form-control" Width="320px" Text="24493843"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label14" runat="server" Text="Dirección: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDireccionTrabajo" runat="server" placeholder="Dirección trabajo" class="form-control" Width="320px" Text="Four Seasons"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label15" runat="server" Text="Fecha de inicio: " ForeColor="#308ED5"></asp:Label>
                        <%-- Poner textmode fecha en txtfechainiciotrabajo --%>
                        <asp:TextBox ID="txtFechaInicioTrabajo" runat="server" class="form-control" Width="320px" Text="20/09/2000"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label16" runat="server" Text="Fecha de Finalización: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaFinalizacion" runat="server" TextMode="date" class="form-control" Width="305px"></asp:TextBox>
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Datos académicos</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label17" runat="server" Text="Grado académico: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtGradoAcademico" runat="server" placeholder="Grado académico" class="form-control" Width="320px" Text="Licenciado"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label18" runat="server" Text="Institución: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtInstitución" runat="server" placeholder="Institución" class="form-control" Width="320px" Text="TEC"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
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

