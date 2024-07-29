<%@ Page Title="" Language="C#" MasterPageFile="~/Master/mpCrud.Master" AutoEventWireup="true" CodeBehind="Crud.aspx.cs" Inherits="Login_Usuario.Pages.Crud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Crud
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
        <br />
        <div class="mx-auto" style="width:250px">
            <asp:Label runat="server" CssClass="h2" ID="lblTitulo"></asp:Label>
        </div>
     <form runat="server" class="h-100 d-flex align-items-center justify-content-center">
         <div>
             <div class="mb-3">
                  <label class="form-label">Nombre</label>
                   <asp:TextBox runat="server" CssClass="form-control" ID="TxtNombre"></asp:TextBox>
             </div>
            <div class="mb-3">
                  <label class="form-label">Edad</label>
                   <asp:TextBox runat="server" CssClass="form-control" ID="TxtEdad"></asp:TextBox>
             </div>
             <div class="mb-3">
                   <label class="form-label">Email</label>
                   <asp:TextBox runat="server" CssClass="form-control" ID="TxtEmail"></asp:TextBox>
             </div>
                   <div class="mb-3">
                 <label class="form-label">Fecha de Nacimiento</label>
                <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="TxtFN"></asp:TextBox>
        </div>
              <asp:Button runat="server" CssClass="btn btn-primary" ID="BtnCrear" Text="Crear" Visible="false" OnClick="BtnCrear_Click"/>
             <asp:Button runat="server" CssClass="btn btn-primary" ID="BtnActualizar" Text="Actualizar" Visible="false" OnClick="BtnActualizar_Click"/>
            <asp:Button runat="server" CssClass="btn btn-primary" ID="BtnEliminar" Text="Eliminar" Visible="false" OnClick="BtnEliminar_Click"/>
            <asp:Button runat="server" CssClass="btn btn-primary btn-dark" ID="BtnVolver" Text="Volver" Visible="true" OnClick="BtnVolver_Click"/>
        
            </div>
  
   
       
     </form>
</asp:Content>
