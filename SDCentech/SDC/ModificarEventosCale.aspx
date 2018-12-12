<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="ModificarEventosCale.aspx.cs" Inherits="SDC.ModificarEventosCale" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="css/sweetalert.css" />

    <style type="text/css">
        .auto-style4 {
            width: 300px;
            height: 42px;
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
            <h3 style="color: #308ED5; text-align: center">Registro de Evento para Calendario</h3>
            <div style="text-align: center;">
                <table class="table-condensed" style="margin: 0 auto; border: thin solid #308ED5;">

                    <tr>
                        <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                            <asp:Label ID="Label1" runat="server" Text="Id: " ForeColor="#308ED5"></asp:Label>
                            <asp:TextBox ID="txtId" runat="server" class="form-control" Width="300px" Height="42px" ReadOnly="true"></asp:TextBox>

                        <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                            <asp:Label ID="lbltitulo" runat="server" Text="Titulo: " ForeColor="#308ED5"></asp:Label>
                            <asp:TextBox ID="txtTitulo" runat="server" class="form-control" Width="300px" Height="42px"></asp:TextBox>

                        <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                            <asp:Label ID="lblColor" runat="server" Text="Identificación de Color: " ForeColor="#308ED5"></asp:Label>
                            <asp:DropDownList ID="ddlColor" runat="server" placeholder="Objetivo del curso" class="form-control" Width="320px">
                                <asp:ListItem>Azul</asp:ListItem>
                                <asp:ListItem>Anaranjado</asp:ListItem>
                                <asp:ListItem>Verde</asp:ListItem>
                            </asp:DropDownList>
                    </tr>
                    <tr>
                        <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                            <asp:Label ID="lblfechaInicio" runat="server" Text="Fecha Inicio:" ForeColor="#308ED5"></asp:Label><br />
                            <input type="datetime-local" id="txtFechaInicio" runat="server" class="auto-style4" />

                        <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                            <asp:Label ID="lblfechaFinal" runat="server" Text="Fecha Final:" ForeColor="#308ED5"></asp:Label><br />
                            <input type="datetime-local" id="txtFechaFinal" runat="server" class="auto-style4" />

                        <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                            <asp:Label ID="Label2" runat="server" Text="Pagina Web: " ForeColor="#308ED5"></asp:Label>
                            <asp:TextBox ID="txtPagWeb" runat="server" class="form-control" Width="300px" Height="42px"></asp:TextBox>
                    </tr>

                </table>

            </div>
            <br />
            <br />
            <div class="col-lg-12 text-center">
                <asp:Button ID="btnGuardar" runat="server" Text="Modificar" class="btn btn-form"
                    Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" OnClick="btnModificar_Click" />
            </div>

        </div>



    </div>


    <script src="Scripts/sweetalert.min.js"></script>

</asp:Content>

