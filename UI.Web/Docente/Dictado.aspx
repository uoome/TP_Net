<%@ Page Title="" Language="C#" MasterPageFile="~/Docente/SiteDocentes.Master" AutoEventWireup="true" CodeBehind="Dictado.aspx.cs" Inherits="UI.Web.Dictado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="panelGrillaDictados" runat="server">
        <asp:GridView ID="grvDictados" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnLoad="grvDictados_Load" OnSelectedIndexChanged="grvDictados_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Curso" />
                <asp:BoundField HeaderText="Docente" />
                <asp:BoundField HeaderText="Cargo" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:Label ID="lblCartel" runat="server" ForeColor="Green" Text="Cartel"></asp:Label>
        <br />
    </asp:Panel>
    <asp:Panel ID="panelBotonesABM" runat="server">
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
        &nbsp;
        <asp:Button ID="btnEditar" runat="server" Text="Editar" />
        &nbsp;
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
    </asp:Panel>
    <asp:Panel ID="panelFormulario" runat="server">
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
    </asp:Panel>
</asp:Content>
