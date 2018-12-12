<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SDC.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <br />
        <br />
        <div class="product-screen-1 wow fadeInUp" data-wow-delay="0.1s" data-wow-duration="0.1s">
            <div class="tab-content panel-footer" style="background-color: #FFFFFF" align="center">
                <div runat="server" class="panel-group">
                    <div class="container ">
                        <div class="col-lg-6 col-lg-offset-3 text-center" style="border: thin solid #308ED5">
                            <br />

                            <div class="inner-form">
                                <h3 style="color: #308ED5; margin-left: 10px;">Iniciar sesión</h3>
                                <div class="input-group">

                                    <asp:Label ID="lblUser" runat="server" Text="Usuario: " ForeColor="#308ED5"></asp:Label>
                                </div>
                                <div class="input-group">

                                    <asp:TextBox ID="txtUser" runat="server" placeholder="Usuario" class="form-control"></asp:TextBox>
                                </div>
                                <br />

                                <div class="input-group">

                                    <asp:Label ID="lblContra" runat="server" Text="Contraseña: " ForeColor="#308ED5"></asp:Label>
                                </div>
                                <div class="input-group">

                                    <asp:TextBox ID="txtPass" runat="server" type="password" placeholder="Contraseña" class="form-control"></asp:TextBox>
                                </div>
                                <br />

                                <div runat="server" class="active">
                                    <asp:Button ID="btnLogin" runat="server" OnClick=" btnLogin_Click" Style="float: right" Text="Ingresar" class="btn btn-form"
                                        Width="130px" BorderStyle="None" Font-Bold="False" Font-Italic="False" CssClass="btn-success" ForeColor="White" Height="38px" />
                                    <br />
                                    <br />


                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </section>
    <br />
    <br />
    <br />
    <br />
    <script src="Scripts/sweetalert.min.js"></script>

    <script>


        var err = <%= ErrorM %>;


        if (err != "123") {
            swal("Error", "El usuario o contraseña son incorrectos", "error");

        }
    </script>

</asp:Content>
