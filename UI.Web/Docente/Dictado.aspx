<%@ Page Title="" Language="C#" MasterPageFile="~/Docente/SiteDocentes.Master" AutoEventWireup="true" CodeBehind="Dictado.aspx.cs" Inherits="UI.Web.Dictado" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="panelGrillaDictados" runat="server">
        <asp:GridView ID="grvDictados" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="grvDictados_SelectedIndexChanged" DataKeyNames="ID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Curso" DataField="cur" />
                <asp:BoundField HeaderText="Docente" DataField="docente" />
                <asp:BoundField HeaderText="Cargo" DataField="cargo" />
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
