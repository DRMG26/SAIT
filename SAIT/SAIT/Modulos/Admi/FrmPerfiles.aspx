﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Modulos/Admi/MtrAdmin.master" AutoEventWireup="true" CodeBehind="FrmPerfiles.aspx.cs" Inherits="SAIT.Modulos.Admi.FrmPerfiles" %>

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
                    <div class="my-3 p-3 jumbotron rounded shadow-sm">
                        <div class="form-row">
                            <div class="col-md-6">
                                
                                <label>Codigo de Ususario</label>
                                <asp:TextBox CssClass="form-control" ID="TxtCod" runat="server" OnTextChanged="TxtCod_TextChanged" AutoPostBack="true"></asp:TextBox>


                                <label>Contraseña</label>
                                <asp:TextBox class="form-control" ID="TxtContra" runat="server"></asp:TextBox>
                                
                                <label>Confirmar Contraseña</label>
                                <asp:TextBox class="form-control" ID="TxtContra2" runat="server"></asp:TextBox>


                                <label>Documento</label>
                                <div class="input-group mb-3">
                                    <asp:TextBox class="form-control" ID="TxtDoc" runat="server"></asp:TextBox>
                                    <div class="input-group-append">
                                        <button class="btn btn-outline-secondary" type="button" id="button-addon2">Buscar</button>
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

                    <div class="form-row">
                        <div class="col-md-4">
                            <asp:Button CssClass="btn btn-success btn-block" ID="BtnGuardar" runat="server" Text="Borrar" OnClick="BtnGuardar_Click" />
                        </div>
                        <div class="col-md-4">
                            <asp:Button CssClass="btn btn-danger btn-block" ID="BtnBorrar" runat="server" Text="Borrar" OnClick="BtnBorrar_Click" />
                        </div>
                        <div class="col-md-4">
                            <asp:Button CssClass="btn btn-secondary btn-block" ID="BtnLimpiar" runat="server" Text="Limpiar" OnClick="BtnLimpiar_Click" />
                        </div>
                    </div>

                </div>

</asp:Content>

