<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvCursos" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ID" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
            <asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" />
            <asp:BoundField DataField="IDComision" HeaderText="ID Comision" />
            <asp:BoundField DataField="IDMateria" HeaderText="ID Materia" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="Black" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:Panel ID="panelABM" runat="server">
        <asp:LinkButton ID="linkBtnNuevo" runat="server" OnClick="linkBtnNuevo_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkBtnEditar" runat="server" OnClick="linkBtnEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkBtnEliminar" runat="server" OnClick="linkBtnEliminar_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="panelControles" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblAnioCalendario" runat="server" Text="Año Calendario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAnioCalendario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblCupo" runat="server" Text="Cupo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblIDMateria" runat="server" Text="ID Materia"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIDMateria" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblIDComision" runat="server" Text="ID Comision"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIDComision" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConfirmacion" runat="server" Visible="False">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    </asp:Panel>
</asp:Content>
