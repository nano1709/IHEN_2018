<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="Calendario.aspx.cs" Inherits="SDC.Calendario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .Azul {
            background-color: steelblue;
            color: white;
            font-size: large;
        }

        .Verde {
            background-color: greenyellow;
            color: white;
            font-size: large;
        }

        .Anaranjado {
            background-color: coral;
            color: white;
            font-size: large;
        }
    </style>

    <script src="Scripts/jquery-3.3.1.slim.min.js"></script>

    <asp:Button runat="server" ID="eventosCalendario" class="btn btn-primary btn-block" OnClick="eventosCale_Click" Text="Ver Eventos" Width="369px" />
    <br />
    <asp:Button runat="server" ID="agregarEvento" class="btn btn-primary" OnClick="agregarEvento_Click" Text="Agregar Evento" Width="369px" />

    <br />
    <br />

    <div id="calendar"></div>



    <script>

        $(document).ready(function () {

            $('#calendar').fullCalendar({
                events: [


                    <%= Eventos %>

                ]
            })

        });
    </script>


</asp:Content>
