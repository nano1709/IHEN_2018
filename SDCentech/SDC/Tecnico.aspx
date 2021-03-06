﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Formulario.Master" AutoEventWireup="true" CodeBehind="Tecnico.aspx.cs" Inherits="SDC.Tecnico" %>

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

    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>

    <div class="text-center article-title">
        <h1 style="color: #308ED5">Técnicos
        </h1>
    </div>

    <section style="padding-right: 20px; padding-left: 20px">
        <asp:Button ID="btnNuevo" OnClick="btnNuevo_Click" runat="server" Style="margin: 10px 9px 7px 9px; padding: 10px 9px 7px 9px;" Text="Agregar Nuevo" class="btn btn-form"
            Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn btn-success" ForeColor="White" Height="38px" />
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
                                    <th>Código</th>
                                    <th>Nombre</th>
                                    <th>Perfil Ocupacional</th>
                                    <th>Duración</th>
                                    <th>Practica Profesional</th>
                                    <th>Requisitos</th>
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


            $('.editar').click(function () {

                var datos = $(this).attr('value');
                //console.log(datos);

                var valores = "ModificarTecnico.aspx?editid=" + datos;

                window.location.href = valores;
                console.log(valores);
            });

            $('.borrar').click(function () {


                var datos = $(this).attr('value');

                console.log(datos);

                var dato = datos.split("§");

                console.log(dato);

                var codigo = dato[0];
                var nombre = dato[1];


                console.log("This: " + this);

                var valores = "" + codigo + "&Nombre=" + nombre;

                console.log("Valores: " + valores);
                swal({
                    title: "Quieres eliminar el tecnico " + dato[0] + " " + dato[1] + " ?",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Eliminar",
                    closeOnConfirm: false,


                }, function () {

                    console.log(valores);

                    $.ajax({
                        type: "POST",
                        url: "Tecnico.aspx?deleteid=" + valores,
                        data: "",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: function (msg) {
                            swal("Error", "Un error a ocurrido mientras se trataba de eliminar el tecnico", "error");

                        },
                        error: function (e) {
                            swal("Eliminados!",
                                "El tecnico se ha eliminado",
                                "success",
                                setTimeout(function () {
                                    window.location = "?exito=" + 3 + "&nombreTecEli=" + dato[0] + " " + dato[1];
                                }, 2000));
                        },
                    });
                });

            });


        });
    </script>

</asp:Content>
