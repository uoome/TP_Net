<%@ Page Title="Inscripciones" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvAlumnos" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" DataKeyNames="ID" OnSelectedIndexChanged="grvAlumnos_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" ForeColor="#333333" Font-Bold="True" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
        <asp:Label ID="lblAlumno" runat="server" Text="Seleccione un alumno para ver sus inscripciones" ForeColor="Green"></asp:Label>
    <asp:Panel ID="panelGrillaInscripciones" runat="server" Visible="True">
    </asp:Panel>
    <asp:Panel ID="panelControlesInscripciones" runat="server" Visible="False">
        <asp:GridView ID="grvInscripciones" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="curs" ForeColor="#333333" OnSelectedIndexChanged="grvInscripciones_SelectedIndexChanged" ClientIDMode="AutoID">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="curs" HeaderText="Curso" />
                <asp:BoundField DataField="com" HeaderText="Comision" />
                <asp:BoundField DataField="año" HeaderText="Año materia" />
                <asp:BoundField DataField="desc_materia" HeaderText="Materia" />
                <asp:BoundField DataField="estado" HeaderText="Condicion" />
                <asp:BoundField DataField="nota" HeaderText="Nota" />
                <asp:BoundField DataField="desc_plan" HeaderText="Plan" />
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
        <asp:Button ID="btnAgregarInscripcion" runat="server" Text="Agregar" OnClick="btnAgregarInscripcion_Click" />
        &nbsp;
        <asp:Button ID="btnEditarInscripcion" runat="server" Text="Editar" OnClick="btnEditarInscripcion_Click" />
        &nbsp;
        <asp:Button ID="btnEliminarInscripcion" runat="server" Text="Eliminar" OnClick="btnEliminarInscripcion_Click" />
        <br />
        <asp:Label ID="lblInscripcion" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblInscripcion2" runat="server"></asp:Label>
        <asp:Label ID="lblInscripcion3" runat="server"></asp:Label>
    </asp:Panel>
            <asp:Panel ID="panelABMInscripciones" runat="server" Visible="False">
                <table id="tblABM" style="width:100%;">
                    <tr>
                        <td aria-autocomplete="both">
                            <asp:Label ID="lblCondicion" runat="server" Text="Condicion"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlCondicion" runat="server" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 26px">
                            <asp:Label ID="lblNota" runat="server" Text="Nota"></asp:Label>
                        </td>
                        <td style="height: 26px">
                            <asp:DropDownList ID="ddlNotas" runat="server" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click1" Text="Aceptar" />
                        </td>
                        <td>
                            <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click1" Text="Cancelar" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            </asp:Content>
