<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvMaterias" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="ID" ForeColor="Black" OnSelectedIndexChanged="grvMaterias_SelectedIndexChanged" CellSpacing="2">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="IDplan" HeaderText="ID Plan" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion de la Materia" />
            <asp:BoundField DataField="HSSemanales" HeaderText="Horas semanales" />
            <asp:BoundField DataField="HSTotales" HeaderText="Horas totales" />
            <asp:BoundField DataField="Anio" HeaderText="Año de la materia" />
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
    <asp:Panel ID="panelControles" runat="server">
        <asp:LinkButton ID="linkbtnNuevo" runat="server" OnClick="linkbtnNuevo_Click" CausesValidation="false">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkbtnEditar" runat="server" OnClick="linkbtnEditar_Click" CausesValidation="false">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkbtnEliminar" runat="server" OnClick="linkbtnEliminar_Click" CausesValidation="false">Eliminar</asp:LinkButton>
        &nbsp;
        <asp:Label ID="lblCartel" runat="server" ForeColor="Green" Text="Cartel" Visible="False"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="panelFormulario" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td>
                    Descripcion</td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" Display="None" ErrorMessage="No puede estar vacio Descripcion" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAnio" runat="server" Text="Año de la materia"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAnio" runat="server" ControlToValidate="txtAnio" Display="None" ErrorMessage="No puede estar vacio el año" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Especialidad</td>
                <td>
                    <asp:DropDownList ID="ddlEspecialidades" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvEspecialidades" runat="server" ErrorMessage="Debe seleccionar una especialidad para elegir un plan" ForeColor="Red" ControlToValidate="ddlEspecialidades">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Plan</td>
                <td>
                    <asp:DropDownList ID="ddlPlanes" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvPlan" runat="server" ErrorMessage="Debe seleccionar un plan" ForeColor="Red" ControlToValidate="ddlPlanes">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsSemanales" runat="server" Text="Hs semanales"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsSemanales" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvHsSemanales" runat="server" ControlToValidate="txtHsSemanales" Display="None" ErrorMessage="No puede estar vacio hs semanales" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblhsTotales" runat="server" Text="Hs totales"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsTotales" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvHsTotales" runat="server" ControlToValidate="txtHsTotales" Display="None" ErrorMessage="Las hs totales no pueden estar vacias" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConfirmacion" runat="server" Visible="False">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="false"/>
    </asp:Panel>
    <asp:ValidationSummary ID="vsMaterias" runat="server" ForeColor="Red" ShowValidationErrors="true"/>
</asp:Content>
