<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="tpc_equipo3a_inmobiliaria.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
            <h2>Nuevo Cliente</h2>
            <div class="form-group">
                <label for="txtNombre">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtApellido">Apellido</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCelular">Celular</label>
                <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" placeholder="Celular"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEmail">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtDNI">DNI</label>
                <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" placeholder="DNI"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtUbicacion">Ubicación</label>
                <asp:TextBox ID="txtUbicacion" runat="server" CssClass="form-control" placeholder="Ubicación"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtProvincia">Provincia</label>
                <asp:TextBox ID="txtProvincia" runat="server" CssClass="form-control" placeholder="Provincia"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtLocalidad">Localidad</label>
                <asp:TextBox ID="txtLocalidad" runat="server" CssClass="form-control" placeholder="Localidad"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCalle">Calle</label>
                <asp:TextBox ID="txtCalle" runat="server" CssClass="form-control" placeholder="Calle"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtCP">Código Postal</label>
                <asp:TextBox ID="txtCP" runat="server" CssClass="form-control" placeholder="Código Postal"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtNumero">Número</label>
                <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" placeholder="Número"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary"  />
            </div>
        </div>
</asp:Content>
