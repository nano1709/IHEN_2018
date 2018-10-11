<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="Estudiante.aspx.cs" Inherits="SDC.Estudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <style>
        .modal-body {
            max-height: calc(100vh - 210px);
            overflow-y: auto;
        }

        div.demo {
            padding: 5px;
            position: relative;
            width: auto;
            height: auto;
            overflow: auto;
        }

        .checkmark {
            height: 30px;
            width: 30px;
            background-color: #eee;
        }

        .container input:checked ~ .checkmark {
            background-color: #2196F3;
        }
    </style>

    <h1>
        <asp:Label ID="LbTipo" runat="server" Text=""></asp:Label></h1>


    <div class="text-center article-title">
        <h1 style="color: #308ED5">Estudiantes
        </h1>
    </div>

    <div class="row">
        <div class="col-lg-12">
            <div class="ibox float-e-margins">
                <div class="ibox-title">
                </div>
                <div class="ibox-content">

                    <table class="table table-striped table-bordered table-hover dataTables-example">

                        <thead>
                            <tr>
                                <th>Cedula</th>
                                <th>Nombre</th>
                                <th>Carrera</th>
                                <th>Fecha Ingreso</th>
                                <th>Telefono</th>
                                <th>Correo Electronico</th>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>117200742</td>
                                <td>Ignacio Vargas</td>
                                <td>Informatica</td>
                                <td>20/3/2018</td>
                                <td>83085434</td>
                                <td>ignacio@hotmail.com</td>
                                <td>
                                    <asp:Button runat="server" Text="Ver" CssClass="btn btn-warning" /></td>
                                <td>
                                    <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" /></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>


    <asp:Button CssClass="btn btn-primary" ID="AgregarEstudiante" OnClick="AgregarEstudiante_Click" Text="Agregar Estudiante" runat="server" />

    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.css"/>
    <script src="Scripts/jquery-3.3.1.slim.min.js"></script>

    <script>
        $(document).ready(function () {


            $('.dataTables-example').dataTable({
                dom: '<"html5buttons"B>lTfgitp',
                buttons: [
                    { extend: 'copy' },
                    { extend: 'csv' },
                    { extend: 'excel', title: 'ExampleFile' },
                    { extend: 'pdf', title: 'ExampleFile' },

                    {
                        extend: 'print',
                        customize: function (win) {
                            $(win.document.body).addClass('white-bg');
                            $(win.document.body).css('font-size', '10px');

                            $(win.document.body).find('table')
                                .addClass('compact')
                                .css('font-size', 'inherit');
                        }
                    }
                ]

            });
        });
    </script>

</asp:Content>
