<%@ Page Title="" Language="C#" MasterPageFile="~/Modulos/Admi/MtrAdmin.master" AutoEventWireup="true" CodeBehind="FrmRegiUsu.aspx.cs" Inherits="SAIT.Modulos.Admi.FrmRegiUsu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row ">

        <div class="col-md-3">
            <div class="jumbotron">
                <center>
                    <h1>Usuarios</h1>
                </center>
            </div>
        </div>

        <div class="col-md-9">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>


                    <div class="my-3 p-3 jumbotron rounded shadow-sm">
                        <div class="form-row">
                            <div class="col-md-6">

                                <label>Documento</label>
                                <div class="input-group mb-3">
                                    <asp:TextBox class="form-control" ID="TxtDoc"  runat="server" OnTextChanged ="TxtDoc_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    <div class="input-group-append">
                                        <asp:DropDownList class="custom-select" ID="CmdTipDoc" runat="server" >
                                            <asp:ListItem Selected="True" Value="0"  Text="CC"></asp:ListItem> 
                                            <asp:ListItem Value="1"  Text="TI"></asp:ListItem> 
                                            <asp:ListItem Value="2"  Text="2"></asp:ListItem> 
                                            <asp:ListItem Value="3"  Text="3"></asp:ListItem> 
                                        </asp:DropDownList>
                                    </div>
                                </div>

                                <label>Nombres</label>
                                <asp:TextBox class="form-control" ID="TxtNom" runat="server"></asp:TextBox>

                                <label>Apeliidos</label>
                                <asp:TextBox class="form-control" ID="TxtApe" runat="server"></asp:TextBox>
                            </div>

                            <div class="col-md-6">
                                <label>Correo</label>
                                <asp:TextBox class="form-control" ID="TxtEmail" runat="server"></asp:TextBox>

                                <label>Telefono</label>
                                <asp:TextBox class="form-control" ID="TxtTel" runat="server"></asp:TextBox>

                                <label>Direccion</label>
                                <asp:TextBox class="form-control" ID="TxtDir" runat="server"></asp:TextBox>

                            </div>


                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="form-row">
                <div class="col-md-4">

                    <asp:LinkButton CssClass="btn btn-success btn-block" ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click" >
                                <i class="fas fa-save"></i><span> Guardar</span>
                    </asp:LinkButton>


                </div>
                <div class="col-md-4">
                    <asp:LinkButton CssClass="btn btn-danger btn-block" ID="BtnBorrar" runat="server" OnClick ="BtnBorrar_Click">
                                <i class="fas fa-eraser"></i><span> Borrar</span>
                    </asp:LinkButton>

                </div>
                <div class="col-md-4">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:LinkButton CssClass="btn btn-secondary btn-block" ID="BtnLimpiar" runat="server" OnClick="BtnLimpiar_Click">
                                <i class="fas fa-magic"></i><span> Limpiar</span>
                            </asp:LinkButton>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
