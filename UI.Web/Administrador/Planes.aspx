<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="panelControles" runat="server">
        <asp:Panel ID="panelGrilla" runat="server">
            <asp:GridView ID="grvPlanes" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" OnSelectedIndexChanged="grvPlanes_SelectedIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID Plan" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="IDEspecialidad" HeaderText="ID Especialidad" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
        </asp:Panel>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CausesValidation="false"/>
        &nbsp;&nbsp;<asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" CausesValidation="false"/>
&nbsp;
        <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" CausesValidation="false"/>
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
                        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" CausesValidation="false"/>
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