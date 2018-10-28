<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SDC.Menu1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />

    <div class="col-lg-12 text-center">
        <div class="row">
            <div class="col-lg-4">
                <asp:ImageButton ID="btnPaciente" runat="server" ImageUrl="~/img/alumno.png" PostBackUrl="~/Estudiante.aspx" />
                <h4>Estudiantes</h4>
            </div>
            <div class="col-lg-4">
                <asp:ImageButton ID="btnDiag" runat="server" ImageUrl="~/img/profe.png" PostBackUrl="~/Profesor.aspx" />
                <h4>Profesores</h4>
            </div>
            <div class="col-lg-4">
                <asp:ImageButton ID="btnCitas" runat="server" ImageUrl="~/img/calen.png" PostBackUrl="~/Calendario.aspx" />
                <h4>Calendario</h4>
            </div>
        </div>
    </div>
    <br />
    <div class="col-lg-12 text-center">
        <div class="row">
            <div class="col-lg-4">
                <asp:ImageButton ID="btnMedicamentos" runat="server" ImageUrl="~/img/tecnic.png" PostBackUrl="~/Tecnico.aspx" />
                <h4>Técnicos</h4>
            </div>
            <div class="col-lg-4">
                <asp:ImageButton ID="BtnCalculos" runat="server" ImageUrl="~/img/urs.png" PostBackUrl="~/Curso.aspx" />
                <h4>Cursos</h4>
            </div>
            <div class="col-lg-4">
                <asp:ImageButton ID="btnPerfil" runat="server" ImageUrl="~/img/modulos.png" PostBackUrl="~/Modulo.aspx" />
                <h4>Módulos</h4>
            </div>
        </div>
    </div>
    <br />
    <div class="col-lg-12 text-center">
        <asp:ImageButton ID="btnDocum" runat="server" ImageUrl="~/img/docum.png" PostBackUrl="~/Documento.aspx" />
        <h4>Documentos</h4>
    </div>


    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
