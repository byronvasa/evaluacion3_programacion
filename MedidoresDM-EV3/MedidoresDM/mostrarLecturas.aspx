<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarLecturas.aspx.cs" Inherits="MedidoresDM.MostrarLecturas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="container">
        <h1>Mostrar Lecturas</h1>
        <asp:DropDownList ID="ddlMedidor" runat="server" CssClass="form-control" AppendDataBoundItems="true">
            <asp:ListItem Text="-- Seleccione un medidor --" Value=""></asp:ListItem>

        </asp:DropDownList>

        <asp:GridView ID="gridLecturas" runat="server" CssClass="table table-striped table-bordered">
            <Columns>
                <asp:BoundField DataField="MedidorN°Serie" HeaderText="Número de Serie" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Hora" HeaderText="Hora" DataFormatString="{0:hh\\:mm}" />
                <asp:BoundField DataField="ValorConsumo" HeaderText="Valor de Consumo" DataFormatString="{0:N2}" />

            </Columns>
        </asp:GridView>
    </div>
</asp:Content>