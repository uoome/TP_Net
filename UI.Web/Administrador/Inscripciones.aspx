<%@ Page Title="Inscripciones" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvAlumnos" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" DataKeyNames="ID" OnSelectedIndexChanged="grvInscripciones_SelectedIndexChanged">
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
    <asp:Panel ID="panelCartelAlumnos" runat="server">
        <asp:Label ID="lblInscripcion" runat="server" Text="Seleccione un alumno para ver sus inscripciones" ForeColor="Green"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="panelGrillaInscripciones" runat="server" Visible="False">
        <asp:GridView ID="grvInscripciones" runat="server" AutoGenerateColumns="False" align="center" CellPadding="4" DataKeyNames="ID" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Comision" />
                <asp:BoundField HeaderText="Materia" />
                <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                <asp:BoundField HeaderText="Nota" DataField="Nota" />
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
    <asp:Panel ID="panelControlesInscripciones" runat="server" Visible="False">
        <asp:Button ID="btnAgregarInscripcion" runat="server" Text="Agregar" />
        &nbsp;
        <asp:Button ID="btnEditarInscripcion" runat="server" Text="Editar" />
        &nbsp;
        <asp:Button ID="btnEliminarInscripcion" runat="server" Text="Eliminar" />
        <asp:Panel ID="panelGrillaCursos" runat="server" Visible="False">
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
                        <td>
                            <asp:Label ID="lblNota" runat="server" Text="Nota"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNota" runat="server">0</asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:GridView ID="grvCursos" runat="server" AutoGenerateColumns="False" align="center" CellPadding="4" DataKeyNames="ID" ForeColor="#333333">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="Materia" DataField="Materia" />
                    <asp:BoundField HeaderText="Comision" DataField="Comision" />
                    <asp:BoundField HeaderText="Año calendario" DataField="AnioCalendario" />
                    <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
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
    </asp:Panel>
    </asp:Content>
