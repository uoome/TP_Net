<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grillaPersonas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" OnSelectedIndexChanged="grillaPersonas_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID Persona" ReadOnly="True" />
            <asp:BoundField DataField="TipoPersona" HeaderText="Tipo Persona" />
            <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="FechaDeNacimiento" HeaderText="Fecha de Nacimiento" />
            <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
            <asp:BoundField DataField="Clave" HeaderText="Clave" />
            <asp:BoundField DataField="IDPlan" HeaderText="Plan" />
            <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
            <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:CheckBoxField DataField="Habilitado" HeaderText="Habilitado" />
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
    <asp:Panel ID="panelToolStrip" runat="server">
        <asp:LinkButton ID="lnkButtonNuevo" runat="server" OnClick="lnkButtonNuevo_Click">Nuevo</asp:LinkButton>
        &nbsp;
        <asp:LinkButton ID="lnkButtonEditar" runat="server" OnClick="lnkButtonEditar_Click">Editar</asp:LinkButton>
        &nbsp;
        <asp:LinkButton ID="lnkButtonEliminar" runat="server" OnClick="lnkButtonEliminar_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="panelFormulario" runat="server" Visible="False">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblID_Pers" runat="server" Text="ID Persona"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID_Pers" runat="server" ReadOnly="True" TabIndex="1"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblLegajo" runat="server" Text="Legajo"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLegajo" runat="server" TabIndex="1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" Display="None" ErrorMessage="El legajo no puede estar vacío" ControlToValidate="txtLegajo" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server" TabIndex="2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" Display="None" ErrorMessage="El apellido no puede estar vacío" ControlToValidate="txtApellido" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" TabIndex="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" Display="None" ErrorMessage="El nombre no puede estar vacío" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFeNac" runat="server" Text="Fecha de nacimiento"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFeNac" runat="server" TabIndex="4"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFechaNac" runat="server" Display="None" ErrorMessage="La fecha de nacimiento no puede estar vacía" ControlToValidate="txtFeNac" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server" TabIndex="5"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" Display="None" ErrorMessage="El usuario no puede estar vacío" ControlToValidate="txtUsuario" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtClave" runat="server" TabIndex="6"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCalve" runat="server" ErrorMessage="La clave no puede estar vacía" ControlToValidate="txtClave" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblCambiaClave" runat="server" Text="Cambia Clave"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCambiaClave" runat="server" TabIndex="7"></asp:TextBox>
                    <asp:CompareValidator ID="cpvCambiaCLave" runat="server" ControlToCompare="txtClave" ControlToValidate="txtCambiaClave" Display="None" ErrorMessage="La confirmación de la clave debe coincidir con la clave" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDirec" runat="server" Text="Dirección"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDirec" runat="server" TabIndex="8"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" Display="None" ErrorMessage="La dirección no puede estar vacía" ControlToValidate="txtDirec" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblTelef" runat="server" Text="Teléfono"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelef" runat="server" TabIndex="9"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" TabIndex="10"></asp:TextBox>
                </td>
                <td>
                    <asp:CheckBox ID="chbxHabilitado" runat="server" Text="Habilitado" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEspecialidades" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="lblPlan" runat="server" Text="Plan"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlPlanes" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTipoPers" runat="server" Text="Tipo Persona"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoPers" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="panelConfirmacion" runat="server" Visible="False">
        &nbsp;
        <asp:Button ID="btnAceptar" runat="server" OnClick="btnAceptar_Click" Text="Aceptar" />
        &nbsp;
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
    </asp:Panel>
    </asp:Content>
