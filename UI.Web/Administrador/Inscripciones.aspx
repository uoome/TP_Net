<%@ Page Title="Inscripciones" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvAlumnos" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" OnSelectedIndexChanged="grvAlumnos_SelectedIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
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
    <br />
        <asp:Label ID="lblAlumno" runat="server" Text="Seleccione un alumno para ver sus inscripciones" ForeColor="Green"></asp:Label>
    <asp:Panel ID="panelGrillaInscripciones" runat="server" Visible="True">
    </asp:Panel>
    <asp:Panel ID="panelControlesInscripciones" runat="server" Visible="False">
        <asp:GridView ID="grvInscripciones" runat="server" align="center" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="curs" OnSelectedIndexChanged="grvInscripciones_SelectedIndexChanged" ClientIDMode="AutoID" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
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
        <asp:Button ID="btnAgregarInscripcion" runat="server" Text="Agregar" OnClick="btnAgregarInscripcion_Click" />
        &nbsp;
        <asp:Button ID="btnEditarInscripcion" runat="server" Text="Editar" OnClick="btnEditarInscripcion_Click" />
        &nbsp;
        <asp:Button ID="btnEliminarInscripcion" runat="server" Text="Eliminar" OnClick="btnEliminarInscripcion_Click" />
        <br />
        <asp:Label ID="lblInscripcion" runat="server" ForeColor="Red"></asp:Label>
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
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlCondicion" Display="None" ErrorMessage="No puede estar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 26px">
                            <asp:Label ID="lblNota" runat="server" Text="Nota"></asp:Label>
                        </td>
                        <td style="height: 26px">
                            <asp:DropDownList ID="ddlNotas" runat="server" AutoPostBack="True">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ddlNotas" Display="None" ErrorMessage="No puede estar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
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
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <br />
    <asp:Panel ID="panelInsertMateria" runat="server" Visible="False">
        <br />
        <asp:GridView ID="grvMaterias" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" OnSelectedIndexChanged="grvMaterias_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Anio" HeaderText="Año" />
                <asp:BoundField DataField="Descripcion" HeaderText="Materia" />
                <asp:BoundField DataField="HSSemanales" HeaderText="Horas semanales" />
                <asp:BoundField DataField="HSTotales" HeaderText="Horas totales" />
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
        <br />
        <asp:Panel ID="panelInsertCursos" runat="server" Visible="False">
            <asp:GridView ID="grvComisionesMat" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id_cur" OnSelectedIndexChanged="grvComisionesMat_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="id_cur" HeaderText="Curso" />
                    <asp:BoundField DataField="desc_comi" HeaderText="Comision" />
                    <asp:BoundField DataField="cupo" HeaderText="Cupo" />
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
            <br />
            <asp:Button ID="btnInscripcion" runat="server" OnClick="btnInscripcion_Click" Text="Inscribirse" />
            <br />
            <br />
            <asp:Label ID="lblCurso" runat="server" ForeColor="Red"></asp:Label>
        </asp:Panel>
    </asp:Panel>
            </asp:Content>
