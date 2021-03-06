﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="RegistroProfesor.aspx.cs" Inherits="SDC.RegistroProfesor" %>

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

            <h3 style="color: #308ED5">Registro de profesores</h3>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblFechaIngreso" runat="server" Text="Fecha de ingreso: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaIngreso" runat="server" TextMode="date" class="form-control" Width="320px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ControlToValidate="txtFechaIngreso"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCarrera" runat="server" Text="Carrera técnica: " ForeColor="#308ED5"></asp:Label>
                        <asp:DropDownList ID="ddlCarreraTecnica" runat="server" placeholder="Carrera técnica" class="form-control" Width="320px"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="ddlCarreraTecnica"
                            ErrorMessage="Verificar"
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Datos personales</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCedula" runat="server" Text="Cédula: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCedula" runat="server" TextMode="Number" placeholder="Cédula" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label1" runat="server" Text="Fecha de nacimiento: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="date" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label2" runat="server" Text="Edad: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtEdad" runat="server" TextMode="Number" placeholder="Edad" class="form-control" Width="305px"></asp:TextBox>
                </tr>

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label3" runat="server" Text="Teléfono móvil: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoMovil" runat="server" TextMode="Number" placeholder="Teléfono móvil" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label4" runat="server" Text="Teléfono domicilio: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoDomicilio" runat="server" TextMode="Number" placeholder="Teléfono domicilio" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label5" runat="server" Text="Correo electrónico: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtcorreo" runat="server" placeholder="Correo electrónico" TextMode="email" class="form-control" Width="320px"></asp:TextBox>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label19" runat="server" Text="Genero: " ForeColor="#308ED5"></asp:Label>
                        <asp:DropDownList ID="ddlGenero" runat="server" placeholder="Género" class="form-control" Width="320px">
                            <asp:ListItem>Mujer</asp:ListItem>
                            <asp:ListItem>Hombre</asp:ListItem>
                            <asp:ListItem>Otro</asp:ListItem>
                        </asp:DropDownList>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label6" runat="server" Text="Provincia: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtProvincia" runat="server" placeholder="Provincia" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label7" runat="server" Text="Cantón: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCanton" runat="server" placeholder="Cantón" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label8" runat="server" Text="Distrito: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtxDistrito" runat="server" placeholder="Distrito" class="form-control" Width="320px"></asp:TextBox>
                </tr>
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label13" runat="server" Text="Domicilio exacto: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDomicilio" runat="server" placeholder="Domicilio exacto" TextMode="MultiLine" class="form-control" Width="305"></asp:TextBox>

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
                        <asp:TextBox ID="txtNumeroCuenta" runat="server" TextMode="number" placeholder="Número de cuenta" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label11" runat="server" Text="Banco: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtBanco" runat="server" placeholder="Banco" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Lugar de trabajo</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">
                <tr>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label20" runat="server" Text="Lugar de Trabajo: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtLugar" runat="server" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label12" runat="server" Text="Teléfono: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtTelefonoTrabajo" runat="server" TextMode="number" placeholder="Teléfono trabajo" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label14" runat="server" Text="Dirección: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDireccionTrabajo" runat="server" placeholder="Dirección trabajo" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label15" runat="server" Text="Fecha de inicio: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaInicioTrabajo" runat="server" TextMode="date" class="form-control" Width="320px"></asp:TextBox>
                </tr>
                <tr>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label16" runat="server" Text="Fecha de Finalización: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtFechaFinalizacion" runat="server" TextMode="date" class="form-control" Width="305px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5">Datos académicos</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label17" runat="server" Text="Grado académico: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtGradoAcademico" runat="server" placeholder="Grado académico" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label18" runat="server" Text="Institución: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtInstitución" runat="server" placeholder="Institución" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                </tr>


            </table>
            <br />
            <h5 style="color: #308ED5">Datos Sede</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label9" runat="server" Text="Id Sede: " ForeColor="#308ED5"></asp:Label>
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
                <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" runat="server" Text="Guardar" class="btn btn-form"
                    Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" />
            </div>
            <br />
        </div>
    </div>



</asp:Content>


