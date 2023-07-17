<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidores.aspx.cs" Inherits="MedidoresDM.MostrarMedidores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Mostrar Medidores</h1>
        <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlTipo_SelectedIndexChanged">
            <asp:ListItem Text="Todos" Value=""></asp:ListItem>

        </asp:DropDownList>

        <asp:GridView ID="gridMedidores" runat="server" CssClass="table table-striped table-bordered">
            <Columns>
                <asp:BoundField DataField="NumeroSerie" HeaderText="Número de Serie" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>