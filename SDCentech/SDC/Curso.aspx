<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="SDC.Curso" %>

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
        <h1 style="color: #308ED5">Cursos
        </h1>
    </div>

    <section style="padding-right: 20px; padding-left: 20px">
        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-title">
                    </div>
                    <div class="ibox-content">

                        <table class="table table-striped table-bordered table-hover dataTables-example">

                            <thead>
                                <tr>
                                    <th>CodigoCurso</th>
                                    <th>NombreCurso</th>
                                    <th>Duracion</th>
                                    <th>Objetivo Curso</th>
                                    <th>Material Didactico</th>
                                    <th>Certificacion</th>
                                    <th>Inversion</th>
                                    <th>Metodologia</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <%= Fila %>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>



        <asp:Button CssClass="btn btn-primary" ID="AddCurso" OnClick="AddCurso_Click" Text="Agregar Curso" runat="server" />

    </section>




    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/dt/dt-1.10.18/datatables.min.css" />
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









            $('.dataTables-example').on('click', 'editar', function () {



                var datos = $(this).attr('value');

                var URL = "";
                URL = "CursosForm.aspx?editarid=" + datos;


                $.ajax({


                    type: "POST",
                    url: URL,
                    data: "",
                    datatype: "html"





                });





            });



        });
    </script>


</asp:Content>
