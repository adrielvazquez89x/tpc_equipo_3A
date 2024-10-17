<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agentes.aspx.cs" Inherits="tpc_equipo3a_inmobiliaria.Agentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="d-flex col-md-8 justify-content-between">
                <h2>Agentes</h2>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" Text="Nuevo Agente" />
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>

    </div>
</asp:Content>
