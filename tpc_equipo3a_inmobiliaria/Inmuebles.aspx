<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inmuebles.aspx.cs" Inherits="tpc_equipo3a_inmobiliaria.Inmuebles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="d-flex col-md-8 justify-content-between">
                <h2>Propiedades</h2>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Agregar nueva propiedad" />
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>

    </div>

</asp:Content>
