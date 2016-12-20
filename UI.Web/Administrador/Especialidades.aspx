<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvEspecialidades" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" OnSelectedIndexChanged="grvEspecialidades_SelectedIndexChanged" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
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
        <asp:LinkButton ID="linkbtnNuevo" runat="server" OnClick="linkbtnNuevo_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkbtnEditar" runat="server" OnClick="linkbtnEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkbtnEliminar" runat="server" OnClick="linkbtnEliminar_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="panelControles" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescripcion" Display="None" ErrorMessage="La descripcion no puede estar vacía"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConformacion" runat="server" Visible="False">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
    </asp:Panel>
</asp:Content>
