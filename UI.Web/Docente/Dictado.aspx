<%@ Page Title="" Language="C#" MasterPageFile="~/Docente/SiteDocentes.Master" AutoEventWireup="true" CodeBehind="Dictado.aspx.cs" Inherits="UI.Web.Dictado" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="panelGrillaDictados" runat="server">
        <asp:GridView ID="grvDictados" runat="server" AutoGenerateColumns="False" CellPadding="4" OnSelectedIndexChanged="grvDictados_SelectedIndexChanged" DataKeyNames="ID" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
            <Columns>
                <asp:BoundField HeaderText="Curso" DataField="cur" />
                <asp:BoundField HeaderText="Docente" DataField="docente" />
                <asp:BoundField HeaderText="Cargo" DataField="cargo" />
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
        <asp:Label ID="lblCartel" runat="server" ForeColor="Green" Text="Cartel"></asp:Label>
        <br />
    </asp:Panel>
    <asp:Panel ID="panelBotonesABM" runat="server">
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CausesValidation="false"/>
        &nbsp;
        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" CausesValidation="false"/>
        &nbsp;
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CausesValidation="false" />
    </asp:Panel>
    <asp:Panel ID="panelFormulario" runat="server">
        <table style="width:100%;">
            <tr>
                <td>ID Dictado</td>
                <td>
                    <asp:TextBox ID="txtIDdictado" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Curso</td>
                <td>
                    <asp:DropDownList ID="ddlCursos" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvCurso" runat="server" ControlToValidate="ddlCursos" ErrorMessage="Debe seleccionar un curso" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Docente</td>
                <td>
                    <asp:DropDownList ID="ddlDocentes" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDocentes_SelectedIndexChanged">
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="txtIDdocente" runat="server" Enabled="False" Width="64px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDocente" runat="server" ControlToValidate="ddlDocentes" ErrorMessage="Debe seleccionar un docente" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Cargo</td>
                <td>
                    <asp:DropDownList ID="ddlCargos" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvCargo" runat="server" ControlToValidate="ddlCargos" ErrorMessage="Debe seleccionar un cargo" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" CausesValidation="false" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </asp:Panel>
</asp:Content>
