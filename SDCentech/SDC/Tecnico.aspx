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
                                    <th>Duración</th>
                                    <th>Practica Profesional</th>
                                    <th>Requisitos</th>
                                    <th></th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>0101</td>
                                    <td>Inglés</td>
                                    <td>1 mes</td>
                                    <td>2 semanas 106 horas</td>
                                    <td>Noveno año</td>
                                    <td>
                                        <asp:Button ID="btnVer" OnClick="btnVer_Click" runat="server" Text="Ver" class="btn btn-form"
                                            Font-Bold="False" Font-Italic="False" CssClass="btn btn-info" ForeColor="White" /></td>
                                    <td>
                                        <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" /></td>
                                </tr>
                                <tr>
                                    <td>0102</td>
                                    <td>Seguridad</td>
                                    <td>1 mes</td>
                                    <td>4 semanas 150 horas </td>
                                    <td>Noveno año</td>
                                    <td>
                                        <asp:Button ID="Button1" OnClick="btnVer_Click" runat="server" Text="Ver" class="btn btn-form"
                                            Font-Bold="False" Font-Italic="False" CssClass="btn btn-info" ForeColor="White" /></td>
                                    <td>
                                        <asp:Button runat="server" Text="Eliminar" CssClass="btn btn-danger" /></td>
                                </tr>
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
        });
    </script>

</asp:Content>
