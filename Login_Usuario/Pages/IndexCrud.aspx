<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mpCrud.Master" AutoEventWireup="true" CodeBehind="IndexCrud.aspx.cs" Inherits="Login_Usuario.Pages.IndexCrud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <form runat="server">
        <br />
        <div class="mx-auto" style="width:300px" >
            <h2>Lista de registros</h2>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div class="col align-self-end">
                     <asp:Button runat="server" ID="BtnCrear" CssClass="btn btn-success form-control-sm" Text="Crear" OnClick="BtnCrear_Click" />
                </div>
            </div>
        </div>
        <br />
        <div class="container row">
            <div class="table small">
                <asp:GridView runat="server" ID="grusuarios" CssClass="table table-borderless table-hover">
                    <Columns>
                        <asp:TemplateField HeaderText="Opciones del Administrador">
                            <ItemTemplate>
                                <asp:Button runat="server" Text="Leer" CssClass="btn form-control-sm btn-info" ID="BtnLeer" OnClick="BtnLeer_Click"/>
                                <asp:Button runat="server" Text="Actualizar" CssClass="btn form-control-sm btn-warning" ID="BtnActualizar" OnClick="BtnActualizar_Click"/>
                                <asp:Button runat="server" Text="Eliminar" CssClass="btn form-control-sm btn-danger" ID="BtnEliminar" OnClick="BtnEliminar_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </form>
        
</asp:Content>
