<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="SDC.RegistroUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style2 {
            width: 278px;
        }
    </style>


    <link rel="stylesheet" type="text/css" href="css/sweetalert.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3 style="color: #308ED5; text-align: center">Registro de Usuarios</h3>

    <div style="text-align: center;">

        <table class="table-condensed" style="margin: 0 auto; border: thin solid #308ED5;">

            <tr>
                <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <asp:Label ID="lblNU" runat="server" Text="Nombre de Usuario: " ForeColor="#308ED5"></asp:Label>
                    <asp:TextBox ID="txtNU" runat="server" class="form-control" placeholder="Nombre de Usuario" Width="320px"></asp:TextBox>

                <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <asp:Label ID="Label1" runat="server" Text="Correo electrónico: " ForeColor="#308ED5"></asp:Label>
                    <asp:TextBox ID="txtCE" runat="server" placeholder="Correo Electrónico" class="form-control" Width="320px"></asp:TextBox>
            </tr>
            <tr>



                <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <asp:Label ID="lbl" runat="server" Text="Contraseña:" ForeColor="#308ED5"></asp:Label>
                    <asp:TextBox ID="txtContraseña" runat="server" placeholder="Contraseña" class="form-control" Width="320px"></asp:TextBox>

                <td style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;">
                    <asp:Label ID="lblNombreCurso" runat="server" Text="Roll:" ForeColor="#308ED5"></asp:Label>
                    <asp:TextBox ID="txtNombreCurso" runat="server" placeholder="Roll" class="form-control" Width="320px" TextMode="number"></asp:TextBox>
            </tr>





        </table>



    </div>
    <div class="col-lg-12 text-center">
        <br />
        <br />
        <asp:Button ID="btnGuardar" runat="server" Text="Agregar" class="btn btn-form"
            Width="130px" BorderStyle="None" Font-Bold="False" OnClick="btnGuardar_Click" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" />
        <asp:Button ID="btnBack" runat="server" Text="Regresar" class="btn btn-form"
            Width="130px" BorderStyle="None" Font-Bold="False" OnClick="btnBack_Click" Font-Italic="False" CssClass="btn-secondary" ForeColor="White" Height="38px" />
    </div>



    <script src="Scripts/sweetalert.min.js"></script>


    <script>



        function Mensaje() {



            swal("Error", "Debe de llenar todos los campos", "error");



        }
    </script>


</asp:Content>

