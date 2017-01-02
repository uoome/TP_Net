<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvCursos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderWidth="1px" CellPadding="4" DataKeyNames="ID" OnSelectedIndexChanged="grvCursos_SelectedIndexChanged" BorderStyle="None">
        <Columns>
            <asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
            <asp:BoundField DataField="CupoDis" HeaderText="Cupos disnponibles" />
            <asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" />
            <asp:BoundField DataField="IDComision" HeaderText="ID Comision" />
            <asp:BoundField DataField="IDMateria" HeaderText="ID Materia" />
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
        <asp:LinkButton ID="linkBtnNuevo" runat="server" OnClick="linkBtnNuevo_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkBtnEditar" runat="server" OnClick="linkBtnEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkBtnEliminar" runat="server" OnClick="linkBtnEliminar_Click">Eliminar</asp:LinkButton>
        &nbsp;<asp:Label ID="lblCartel" runat="server" ForeColor="Green" Text="Cartel" Visible="False"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="panelControles" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblAnioCalendario" runat="server" Text="Año Calendario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAnioCalendario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAnioCalendario" Display="None" ErrorMessage="No puede estar vacío el año" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblCupo" runat="server" Text="Cupo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCupo" Display="None" ErrorMessage="No puede estar vacio el cupo" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblCupoDis" runat="server" Text="Cupo disponible"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCupoDis" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCupoDis" Display="None" ErrorMessage="No puede estar vacio el cupo disponible" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblIDMateria" runat="server" Text="ID Materia"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMateria" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMateria_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlMateria" Display="None" ErrorMessage="No puede estar vacio el id materia" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblDescripcion0" runat="server" Text="Descripcion"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDescripcion" Display="None" ErrorMessage="No puede estar vacia la descripcion" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 289px">
                    <asp:Label ID="lblIDComision" runat="server" Text="ID Comision"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlComision" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlComision" Display="None" ErrorMessage="No puede estar vacio el id Comision" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConfirmacion" runat="server" Visible="False">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </asp:Panel>
</asp:Content>
