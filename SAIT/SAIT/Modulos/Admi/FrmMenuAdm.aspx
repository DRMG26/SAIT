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
                <asp:Button ID="BtnAudi" class="btn btn-outline-primary" runat="server" UseSubmitBehavior="false" Text="Entrar" OnClick="BtnAudi_Click" />
            </p>
        </div>

        <div class="col-md-3">
            <h2>Perfiles</h2>
            <p>
                Formulario en donde a cada usuario se prodra asigarnar un respectivo perfil.
            </p>
            <p>
                <a class="btn btn-outline-primary" href="#">Entrar &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Documentacion</h2>
            <p>
                Formulario en donde se prodra requistrar nuevos documenos o grupos y relacionarlos
            </p>
            <p>
                <a class="btn btn-outline-primary" href="#">Entrar &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Usuarios</h2>
            <p>
                Formulario en donde se prodra requistrar nuevos usuarios o actualizar su informacion
            </p>
            <p>
                <a id="BtnCerrar" class="btn btn-outline-primary" href="#">Entrar &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
