<%@ Page Title="" Language="C#" MasterPageFile="~/Modulos/Admi/MtrAdmin.master" AutoEventWireup="false" CodeBehind="FrmMenuAdm.aspx.cs" Inherits="SAIT.Modulos.Admi.FrmMenuAdm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <center>
        <h1 align="center">ADMINISTRACION</h1>
            </center>
    </div>

    <div class="row">
        <div class="col-md-3">
            <h2>Auditoria</h2>
            <p>Formulario en donde se puede observar los moveimientos de cada tabla por BD de cada Usuario</p>
            <p>
                <asp:LinkButton OnClick="BtnAudi_Click" ID="BtnAudi" runat="server" CssClass="btn btn-outline-primary">
                    <span>Entrar &raquo;</span>
                </asp:LinkButton>

            </p>
        </div>

        <div class="col-md-3">
            <h2>Perfiles</h2>
            <p>
                Formulario en donde a cada usuario se prodra asigarnar un respectivo perfil.
            </p>
            <p>
                <asp:LinkButton OnClick="LBtnPefi_click" ID="LBtnPerfi" runat="server" CssClass="btn btn-outline-primary">
                    <span>Entrar &raquo;</span>
                </asp:LinkButton>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Documentacion</h2>
            <p>
                Formulario en donde se prodra requistrar nuevos documenos o grupos y relacionarlos
            </p>
            <p>
                <asp:LinkButton ID="LBtnDocu" runat="server" CssClass="btn btn-outline-primary">
                    <span>Entrar &raquo;</span>
                </asp:LinkButton>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Usuarios</h2>
            <p>
                Formulario en donde se prodra requistrar nuevos usuarios o actualizar su informacion
            </p>
            <p>
                <asp:LinkButton ID="LBtnUsu" runat="server" CssClass="btn btn-outline-primary" OnClick="LBtnUsu_Click">
                    <span>Entrar &raquo;</span>
                </asp:LinkButton>
            </p>
        </div>
    </div>

</asp:Content>
