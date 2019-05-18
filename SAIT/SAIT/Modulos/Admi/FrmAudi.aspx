<%@ Page Title="" Language="C#" MasterPageFile="~/Modulos/Admi/MtrAdmin.master" AutoEventWireup="true" CodeBehind="FrmAudi.aspx.cs" Inherits="SAIT.Modulos.Admi.FrmAudi" %>

<asp:Content ID="contenido" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row ">
        <div class="col-md-3">

            <div class="jumbotron">
                <center>
        <h1 align="center">Auditoria</h1>
            </center>
            </div>
        </div>
        <div class="col-md-9">
            <div class="my-3 p-3 jumbotron rounded shadow-sm">
                <div class="row">
                    <div class="col-md-6 ">
                        <label>Fecha</label>
                        <asp:TextBox type="date" name="bday" max="3000-12-31" min="1000-01-01" class="form-control" ID="TxtFecha" runat="server"></asp:TextBox>
                    </div>
                </div>
                <p>
                    <label>Usuario</label>
                    <asp:DropDownList  class="custom-select mb-2 mr-sm-2 mb-sm-0"  ID="CmdUsu" runat="server" OnSelectedIndexChanged="Selecttabla" AutoPostBack="true"    ></asp:DropDownList>
                </p>
                <p>
                    <label>Tabla</label>
                    <asp:DropDownList class="custom-select mb-2 mr-sm-2 mb-sm-0" ID="CmdTabla" runat="server"  OnSelectedIndexChanged="CmdTabla_SelectedIndexChanged" ></asp:DropDownList>
                </p>
                <asp:Button ID="Button2" class="btn btn-outline-secondary" runat="server" UseSubmitBehavior="false"  OnClick="Button2_Click1" Text="Consultar" />


            </div>
        </div>
    </div>

    <div class ="table-responsive">
    <asp:GridView ID="GrdAudi" runat="server" CssClass="table table-striped"  OnSelectedIndexChanged="GrdAudi_SelectedIndexChanged" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="AudFech" HeaderText="Fecha" />
            <asp:BoundField DataField="AudUser" HeaderText="Ususario" />
            <asp:BoundField DataField="AudTabla" HeaderText="Tabla" />
            <asp:BoundField DataField="AudDesc" HeaderText="Descripcion" ItemStyle-Width ="10px"/>
            <asp:BoundField DataField="AudVerExe" ControlStyle-Width ="10%" HeaderText="version" />
            <asp:BoundField DataField="AudFecExe" HeaderText="Fecha" />
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>
