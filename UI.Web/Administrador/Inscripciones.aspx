<%@ Page Title="Inscripciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvInscripciones" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" DataKeyNames="ID" OnSelectedIndexChanged="grvInscripciones_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IdAlumno" HeaderText="ID Alumno" />
            <asp:BoundField DataField="IdCurso" HeaderText="ID Curso" />
            <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
            <asp:BoundField DataField="Nota" HeaderText="Nota" />
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
    <asp:Panel ID="panelBotones" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblIDAlumno" runat="server" Text="ID Alumno"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ddlAlumno" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIDCurso" runat="server" Text="ID Curso"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ddlCursos" runat="server" AutoPostBack="True"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCondicion" runat="server" Text="Condicion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCondicion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCondicion" runat="server" Display="None" ErrorMessage="No puede estar vacio Condicion" ControlToValidate="txtCondicion"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNota" runat="server" Text="Nota"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNota" runat="server" Display="None" ErrorMessage="No puede estar vacio la nota" ControlToValidate="txtNota"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConfirmacion" runat="server" Visible="False">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server"  CausesValidation="false" Text="Cancelar" OnClick="btnCancelar_Click" />
    </asp:Panel>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
