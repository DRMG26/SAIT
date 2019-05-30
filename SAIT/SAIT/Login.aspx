<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SAIT.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link href="~/css/sb-admin.css" rel="stylesheet" />
    <%--Stilo del menu de nevegacion--%>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@8"></script>
    <%--Sweealalert--%>

    <script type="text/javascript">

        function Mensaje(Mensaje, Titulo, Typo) {
            Swal.fire({
                type: Typo,
                title: Mensaje,
                text: Titulo
            })
        }
    </script>
</head>
<body style="background-color: black">
    <form id="Formlogin" runat="server">
        <div class="form-row">
            <div class="col-md-4">
            </div>
            <div class="col-md-4">

                <div class="my-3 p-3 jumbotron rounded shadow-sm">

                    <center>
                        <img src="images/img-01.png" alt="IMG">
                        <h1>INGRSO SAIT</h1>
                    </center>

                    <div class="" data-validate="Verifique su email:Formato no valido">
                        <asp:TextBox ID="TxtUser" class="form-control" placeholder="Cod. Usuario" runat="server"></asp:TextBox>
                    </div>

                    <div class="" data-validate="La contraseña es requerida">
                        <asp:TextBox ID="Txtpass" TextMode="Password" class="form-control" placeholder="Contraseña" runat="server"></asp:TextBox>
                    </div>

                    <div class="">
                        <asp:LinkButton CssClass="btn btn-success btn-block" ID="BtnLogin" runat="server" OnClick="BtnLogin_Click">
                                <i class="fas fa-save"></i><span> Iniciar</span>
                        </asp:LinkButton>
                    </div>
                    <div class="">
                        <asp:LinkButton CssClass="btn btn-danger btn-block" ID="LinkButton1" runat="server" OnClick="Btn_Cancelar_click" >
                                <i class="fas fa-save"></i><span> Cancelar</span>
                        </asp:LinkButton>
                    </div>

                    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [TX_EMAIL_USU], [TX_PASS_USU] FROM [USUARIOS]"></asp:SqlDataSource>--%>

                    <div class="text-center p-t-12">
                        <span class="txt1">Olvido
                        </span>
                        <a href="javascript:comprobar();">¿Usuario? / ¿Contrasña?</a>
                        <a class="txt2" href="#"></a>
                    </div>

                    <div class="text-center p-t-136">
                        <a class="txt2" href="#">Soy nuevo, crear una nueva cuenta
							<i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
                        </a>
                    </div>


                </div>


            </div>
            <div class="col-md-4"></div>
        </div>
    </form>
</body>
</html>
