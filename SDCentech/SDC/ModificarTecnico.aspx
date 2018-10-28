<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="ModificarTecnico.aspx.cs" Inherits="SDC.ModificarTecnico" %>
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

             <h3 style= "color: #308ED5; margin-left: 10px;">Modificación de técnicos</h3>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblNombreTecnico" runat="server" Text="Nombre: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtNombreTecnico"  runat="server" placeholder="Nombre" class="form-control" Width="450px" Text="Ingles"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblPerfil" runat="server" Text="Perfil ocupacional: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtPerfilOcupacional" runat="server" placeholder="Perfil ocupacional" class="form-control" Width="608px" TextMode="MultiLine" Text="El egresado de este técnico contará con la diferencia entre todos los postulantes para aplicar a un trabajo que requiera ingles"></asp:TextBox>
                </tr>
            </table>
            <br />
             <h5 style= "color: #308ED5; margin-left: 10px;">Datos específicos</h5>
            <table class="table-condensed" style="border: thin solid #308ED5; margin-right: 0px; margin-left: 10px;">

                <tr>
                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblDuracion" runat="server" Text="Duración: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtDuracion" runat="server" placeholder="Duración" class="form-control" Width="320px" Text="1 mes"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblPracticas" runat="server" Text="Prácticas profesionales: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtPracticas" runat="server"  placeholder="Prácticas profesionales" class="form-control" Width="320px"  Text="4 semanas 150 horas"></asp:TextBox>

                    <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                        <asp:Label ID="lblRequisitos" runat="server" Text="Requisitos: " ForeColor="#308ED5"></asp:Label>
                        <asp:TextBox ID="txtRequisitos" placeholder="Requisitos" runat="server" TextMode="MultiLine" class="form-control" Width="400px" Text="Noveno Año"></asp:TextBox>

                    
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



