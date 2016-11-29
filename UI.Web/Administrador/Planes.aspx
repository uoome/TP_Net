<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="panelControles" runat="server">
        <asp:Panel ID="panelGrilla" runat="server">
            <asp:GridView ID="grvPlanes" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" CellSpacing="2" DataKeyNames="ID" ForeColor="#333333" OnSelectedIndexChanged="grvPlanes_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID Plan" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="IDEspecialidad" HeaderText="ID Especialidad" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </asp:Panel>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        &nbsp;&nbsp;<asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
&nbsp;
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
        &nbsp;&nbsp;
        <asp:Label ID="lblCartel" runat="server" ForeColor="Green" Text="Cartel" Visible="False"></asp:Label>
        <asp:Panel ID="panelFormulario" runat="server" Height="197px" Visible="False">
            <table class="nav-justified" style="height: 100px;">
                <tr>
                    <td>ID Plan</td>
                    <td>
                        <asp:TextBox ID="txtIDPlan" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Descripción</td>
                    <td>
                        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ErrorMessage="La descripcion no puede estar vacía" ForeColor="Red" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Especialidad</td>
                    <td>
                        <asp:DropDownList ID="ddlEspecialidades" runat="server" AutoPostBack="True">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvEspecialidad" runat="server" ErrorMessage="Debe seleccionar una especialidad" ForeColor="Red" ControlToValidate="ddlEspecialidades">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                        <br />
                        <br />
                    </td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="vsPlanes" runat="server" ForeColor="Red"  ShowValidationErrors="true" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </asp:Panel>
</asp:Content>