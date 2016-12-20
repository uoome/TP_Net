<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvCursos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" OnSelectedIndexChanged="grvCursos_SelectedIndexChanged" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
            <asp:BoundField DataField="CupoDis" HeaderText="Cupos disnponibles" />
            <asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" />
            <asp:BoundField DataField="IDComision" HeaderText="ID Comision" />
            <asp:BoundField DataField="IDMateria" HeaderText="ID Materia" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" ForeColor="#663399" Font-Bold="True" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
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
                    <asp:Label ID="lblCupoDis" runat="server" Text="Cupo disponible"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCupoDis" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblIDMateria" runat="server" Text="ID Materia"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ddlMateria" runat="server" OnSelectedIndexChanged="ddlMateria_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblIDComision" runat="server" Text="ID Comision"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ddlComision" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlComision_SelectedIndexChanged"></asp:ListBox>
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
