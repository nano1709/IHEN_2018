<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SDC.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" type="text/css" href="fonts/sweetalert.css" />
    <link rel="stylesheet" href="/css/Login.css" type="text/css" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1 runat="server" id="h1id" style="color: white;"></h1>

    <!-- USERNAME INPUT -->
    <label for="username">Usuario</label>
    <asp:TextBox runat="server" ID="txtUser" CssClass="form-control" placeholder="Ingrese su usuario"></asp:TextBox>


    <!-- PASSWORD INPUT -->
    <label for="password">Contraseña</label>
    <asp:TextBox runat="server" ID="txtPass" CssClass="form-control" TextMode="Password" placeholder="Ingrese su contraseña"></asp:TextBox>


    <asp:Button ID="btnLogin" class="btn btn-primary block full-width m-b" runat="server" OnClick="btnLogin_Click" Text="Entrar" />


    <script src="Scripts/sweetalert.min.js"></script>

    <script>


        var err = <%= ErrorM %>;


        if (err != "123") {
            swal("Error", "El usuario o contraseña son incorrectos", "error");

        }



    </script>



</asp:Content>
