<%@ Page Title="" Language="C#" MasterPageFile="~/ErrorMasterPage.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="SDC.PaginaError.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-lg-12 text-center" align="center">
        <asp:Image ID="Image2" runat="server" ImageUrl="~/img/robot.png" />
        <h1>Error 404</h1>
        <h2>Lo sentimos, página no encontrada.</h2>
        <asp:Button ID="btnVolver" runat="server" Text="VOLVER AL MENÚ" class="btn btn-form"
            Width="150px" BorderStyle="None" Font-Bold="False" Font-Italic="False"
            CssClass="btn-info" ForeColor="White" Height="38px" PostBackUrl="~/Menu.aspx"
            BackColor="#0C3E6B" Font-Size="Smaller" />
    </div>


</asp:Content>

