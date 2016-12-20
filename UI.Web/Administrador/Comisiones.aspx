<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Administrador.Comisiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="panelGrilla" runat="server">
    <asp:GridView ID="grvComisiones" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="grvComisiones_SelectedIndexChanged" DataKeyNames="ID" BackColor="White" BorderColor="#CC9966" BorderWidth="1px" CellPadding="4" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="Id Comision" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion comision" />
            <asp:BoundField DataField="AnioEspecialidad" HeaderText="Año especialidad" />
            <asp:BoundField DataField="IdPlan" HeaderText="Id Plan" />
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
    <asp:Panel ID="Panel2" runat="server">
        <asp:LinkButton ID="linkNuevo" runat="server" OnClick="linkNuevo_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkEditar" runat="server" OnClick="linkEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkEliminar" runat="server" OnClick="linkEliminar_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <br />
    <asp:Panel ID="panelInsert" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 20px">
                    <asp:Label ID="lblAnioEspecialidad" runat="server" Text="Año especialidad"></asp:Label>
                </td>
                <td style="height: 20px">
                    <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIdPlan" runat="server" Text="IdPlan"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPlanes" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPlanes_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDescPlan" runat="server" Text="Descripcion Plan"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcionPlan" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Panel>
</asp:Content>
