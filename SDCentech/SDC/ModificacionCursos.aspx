<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="ModificacionCursos.aspx.cs" Inherits="SDC.ModificacionCurso" %>

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

            <h3 style="color: #308ED5; margin-left: 10px;">Modificación de cursos</h3>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCodigoCurso" runat="server" Text="Codigo del Curso: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCodigoCurso" runat="server" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblNombreCurso" runat="server" Text="Nombre del curso:" ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtNombreCurso" runat="server" placeholder="Nombre del curso" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblDuracion" runat="server" Text="Duración del curso:" ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDuracion" runat="server" placeholder="Duración del curso" class="form-control" Width="320px"></asp:TextBox>
                </tr>
                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblObjetivoCurso" runat="server" Text="Objetivo del Curso: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtObjetivoCurso" runat="server" placeholder="Objetivo del curso" class="form-control" Width="320px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblMaterial" runat="server" Text="Material Didactico: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtMaterial" runat="server" placeholder="Material Didactico" class="form-control" Width="320px"></asp:TextBox>


                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCertificacion" runat="server" Text="Certificación: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCertificacion" runat="server" placeholder="Certificación" class="form-control" Width="320px"></asp:TextBox>
                </tr>
                <tr>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblInversion" runat="server" Text="Inversion: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtInversion" runat="server" placeholder="Inversión" class="form-control" Width="320px"></asp:TextBox>


                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblMetodologia" runat="server" Text="Metodología: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtMetodologia" runat="server" placeholder="Metodología" class="form-control" Width="320px"></asp:TextBox>


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
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-form"
                    Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" OnClick="btnGuardar_Click" />

            </div>

        </div>



    </div>

    <script src="Scripts/sweetalert.min.js"></script>


    <script>

        function Mensaje() {



            swal("Error", "Debe de llenar todos los campos", "error");



        }

    </script>


</asp:Content>
