<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MedidoresDM.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Ingresar Medidor</h1>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />

        <asp:TextBox ID="txtNumeroSerie" runat="server" CssClass="form-control" placeholder="Número de Serie"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNumeroSerie" runat="server" ControlToValidate="txtNumeroSerie" ErrorMessage="Ingrese el número de serie" CssClass="text-danger"></asp:RequiredFieldValidator>

        <asp:TextBox ID="txtTipo" runat="server" CssClass="form-control" placeholder="Tipo"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTipo" runat="server" ControlToValidate="txtTipo" ErrorMessage="Ingrese el tipo" CssClass="text-danger"></asp:RequiredFieldValidator>



        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
    </div>
</asp:Content>