<%@ Page Title="" Language="C#" MasterPageFile="~/Modulos/Admi/MtrAdmin.master" AutoEventWireup="true" CodeBehind="FrmPerfiles.aspx.cs" Inherits="SAIT.Modulos.Admi.FrmPerfiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row ">

        <div class="col-md-3">
            <div class="jumbotron">
                <center>
                    <h1>Perfiles</h1>
                </center>
            </div>
        </div>

        <div class="col-md-9">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>


                    <div class="my-3 p-3 jumbotron rounded shadow-sm">
                        <div class="form-row">
                            <div class="col-md-6">

                                <label>Codigo de Ususario</label>
                                <asp:TextBox CssClass="form-control" ID="TxtCod" runat="server" OnTextChanged="TxtCod_TextChanged" AutoPostBack="true"></asp:TextBox>


                                <label>Contraseña</label>
                                <asp:TextBox class="form-control" ID="TxtContra" runat="server"></asp:TextBox>

<%--                                <label>Confirmar Contraseña</label>
                                <asp:TextBox class="form-control" ID="TxtContra2" runat="server"></asp:TextBox>--%>


                                <label>Documento</label>
                                <div class="input-group mb-3">
                                    <asp:TextBox class="form-control" ID="TxtDoc" Enabled ="false"  runat="server"></asp:TextBox>
                                    <div class="input-group-append">
                                        <a class="btn btn-outline-secondary" id="button-addon2" data-toggle="modal" data-target=".BuscarUsu">Buscar</a>
                                    </div>
                                </div>

                            </div>

                            <div class="col-md-6 ">
                                <fieldset style="width: 300px">
                                    <label>Tipo</label>
                                    <div class="form-row align-items-center">

                                        <div class="col-auto">
                                            <asp:RadioButton ID="RadioButton1" runat="server" Text="Admininstracion " GroupName="TipoPerfi" />
                                        </div>

                                        <div class="col-auto">
                                            <asp:RadioButton ID="RadioButton2" runat="server" Text="Moderador" GroupName="TipoPerfi" />
                                        </div>

                                        <div class="col-auto">
                                            <asp:RadioButton ID="RadioButton3" runat="server" Text="Conductor ó Propitario" GroupName="TipoPerfi" />
                                        </div>
                                    </div>
                                </fieldset>
                            </div>

                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="form-row">
                <div class="col-md-4">

                    <asp:LinkButton CssClass="btn btn-success btn-block" ID="BtnGuardar" runat="server" OnClick="BtnGuardar_Click">
                                <i class="fas fa-save"></i><span> Guardar</span>
                    </asp:LinkButton>


                </div>
                <div class="col-md-4">
                    <asp:LinkButton CssClass="btn btn-danger btn-block" ID="BtnBorrar" runat="server" OnClick="BtnBorrar_Click">
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


    <div class ="modal fade BuscarUsu">
        <div class="modal-dialog">
            <div class="modal-content ">
                <div class="modal-header">
                    <div class="row ">
                         <div class="col-md-10">
                             <h2>Buscar un usuario</h2>
                         </div>
                        <div class="col-md-2">
                            <button data-dismiss="modal"Class="btn btn-danger close">X</button>
                        </div>
                    </div>
                </div>
                <div class="modal-body">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>
                     <div class="row ">
                         <div class="col-md-6">
                             <asp:Label ID="Label1" runat="server" Text="Label">Numero de Documento</asp:Label>
                             <asp:TextBox class="form-control" ID="TxtBuscar" runat="server" OnTextChanged ="TxtBuscar_TextChanged"></asp:TextBox>
                         </div>
                         <div class="col-md-6">
                             <asp:LinkButton CssClass="btn btn-success btn-block" ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click1">
                                <i class="fas fa-save"></i><span> Buscar</span>
                             </asp:LinkButton>
                         </div>
                         <div class="table-responsive">
                             <asp:GridView ID="GrdUsus" runat="server" CssClass="table table-striped" OnRowCommand ="GrdUsus_RowCommand" AutoGenerateColumns="False">
                                 <Columns>
                                     <asp:BoundField DataField="TX_DOCU_USU" HeaderText="Documento" />
                                     <asp:BoundField DataField="NOMBRES" HeaderText="Nombres y Apellidos"/>
                                     <asp:ButtonField ButtonType="Button" CommandName="IncreasePrice" Text="Seleccionar"  />
                                 </Columns>
                             </asp:GridView>
                         </div>
                     </div>
                    </ContentTemplate></asp:UpdatePanel>
                </div>
            </div>
        </div>

    </div>

</asp:Content>

