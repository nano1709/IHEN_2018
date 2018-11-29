<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="SDC.Curso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="css/sweetalert.css" />
    <link href="css/datatables.min.css" rel="stylesheet">
    <link href="css/footable.core.css" rel="stylesheet">

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
        <asp:Button CssClass="btn btn-success" ID="AddCurso" OnClick="AddCurso_Click" Text="Agregar Curso" runat="server"
            Style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;" class="btn btn-success"
            Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" ForeColor="White" Height="38px" />
        <br />
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

    </section>
    <br />
    <br />
    <br />



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
                                .css('font-size', 'arial');
                        }
                    }
                ]

            });


            $('.dataTables-example').on('click', '.editar', function () {


                var datos = $(this).attr('value');


                $.ajax({
                    type: "POST",
                    url: "ModificacionCurso.aspx?dat=" + datos,
                    data: "",
                    dataType: "html",
                    success: function (msg) {

                        window.location.href = "ModificacionCursos.aspx?dat=" + datos



                    },
                    error: function (e) {
                        swal("Error", "Un error ha ocurrido", "error");
                    }
                });






            });





            $('.dataTables-example').on('click', '.borrar', function () {


                var dtipd = $(this).attr('value');




                swal({
                    title: "Estás seguro?",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Sí",
                    closeOnConfirm: false
                }, function () {
                    $.ajax({
                        type: "POST",
                        url: "Curso.aspx?deleteid=" + dtipd,
                        data: "",
                        dataType: "html",
                        success: function (msg) {
                            swal({
                                title: "Success",
                                text: "El curso ha sido eliminado",
                                type: "success",
                                confirmButtonText: "Ok",
                                closeOnConfirm: false
                            }, function () {
                                window.location.href = "Curso.aspx"
                            });
                        },
                        error: function (e) {
                            swal("Error", "An error has occured while disabling the Supplier", "error");
                        }
                    });
                });

            });





        });


    </script>


</asp:Content>
