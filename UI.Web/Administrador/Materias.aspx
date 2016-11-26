<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvMaterias" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ID" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="grvMaterias_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IDplan" HeaderText="ID Plan" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion de la Materia" />
            <asp:BoundField DataField="HSSemanales" HeaderText="Horas semanales" />
            <asp:BoundField DataField="HSTotales" HeaderText="Horas totales" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:Panel ID="panelABM" runat="server">
        <asp:LinkButton ID="linkbtnNuevo" runat="server" OnClick="linkbtnNuevo_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkbtnEditar" runat="server" OnClick="linkbtnEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkbtnEliminar" runat="server" OnClick="linkbtnEliminar_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="panelLabels" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescripcion" Display="None" ErrorMessage="No puede estar vacio Descripcion"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIdPlan" runat="server" Text="Id Plan"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlIdPlan" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsSemanales" runat="server" Text="Hs semanales"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsSemanales" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtHsSemanales" Display="None" ErrorMessage="No puede estar vacio hs semanales"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblhsTotales" runat="server" Text="Hs totales"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsTotales" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtHsTotales" Display="None" ErrorMessage="Las hs totales no pueden estar vacias"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConfirmacion" runat="server" Visible="False">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
    </asp:Panel>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
