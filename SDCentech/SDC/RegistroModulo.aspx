<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="RegistroModulo.aspx.cs" Inherits="SDC.RegistroModulo" %>

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

            <h3 style="color: #308ED5; margin-left: 10px;">Registro de módulos</h3>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label2" runat="server" Text="Código: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCodigo" runat="server" placeholder="Código" class="form-control" Width="450px"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblNombreModulo" runat="server" Text="Nombre: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtNombreModulo" runat="server" placeholder="Nombre" class="form-control" Width="450px"></asp:TextBox>
                </tr>
            </table>
            <br />
            <h5 style="color: #308ED5; margin-left: 10px;">Datos específicos</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblCreditos" runat="server" Text="Créditos: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtCreditos" runat="server" placeholder="Créditos" class="form-control" Width="320px" TextMode="Number"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="Label1" runat="server" Text="Duración: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDuracion" runat="server" placeholder="Duración" class="form-control" Width="450px"></asp:TextBox>
                </tr>


            </table>

            <br />

            <div class="col-lg-12 text-center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-form"
                    Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" OnClick="btnGuardar_Click" />
            </div>
            <br />
        </div>
    </div>
</asp:Content>

