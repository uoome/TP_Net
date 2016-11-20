<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvUsuarios" runat="server" AutoGenerateColumns="False" OnLoad="grvUsuarios_Load" OnSelectedIndexChanged="grvUsuarios_SelectedIndexChanged" Width="229px" DataKeyNames="ID">
        <Columns>
            <asp:TemplateField HeaderText="Nombre">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre de Usuario" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Habilitado" HeaderText="Habilitado" />
            <asp:BoundField DataField="Clave" HeaderText="Clave" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Panel ID="Panel2" runat="server">
        <asp:LinkButton ID="NuevoLinkBtn" runat="server" OnClick="NuevoLinkBtn_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="EditarLinkBtn" runat="server" OnClick="EditarLinkBtn_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="EliminarLinkBtn" runat="server" OnClick="EliminarLinkBtn_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" OnLoad="Panel1_Load" Visible="False">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El nombre no puede estar vacío" ControlToValidate="txtNombre" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="rfvApellido" runat="server" ControlToValidate="txtApellido" Display="None" ErrorMessage="El apellido nopuede estar vacío" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre De Usuario"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="rfvNombUs" runat="server" ErrorMessage="El  nombre de usuario no puede estar vacío" ControlToValidate="txtNombreUsuario" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="El email no puede estar vacío" ControlToValidate="txtEmail" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblHabilitado" runat="server" Text="Habilitado"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chbHabilitado" runat="server" />
        <br />
        <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="rfvClave" runat="server" ErrorMessage="La clave no puede estar vacía" ControlToValidate="txtClave" Display="None" ForeColor="Red"></asp:RequiredFieldValidator>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" Visible="False">
        <asp:LinkButton ID="AceptarLinkBtn" runat="server" OnClick="AceptarLinkBtn_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkBtn" runat="server" OnClick="CancelarLinkBtn_Click" CausesValidation="false">Cancelar</asp:LinkButton>
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowValidationErrors="False" />
    </asp:Panel>
</asp:Content>
