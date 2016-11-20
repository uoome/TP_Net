<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="grvUsuarios" runat="server" AutoGenerateColumns="False" OnLoad="grvUsuarios_Load" OnSelectedIndexChanged="grvUsuarios_SelectedIndexChanged" Width="229px">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre de Usuario" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Habilitado" HeaderText="Habilitado" />
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
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="En nombre no puede estar vacio">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="El Ape no puede estar vacio">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre De Usuario"></asp:Label>
        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="El Nombre Us no puede vacio">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Email no vacio">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblHabilitado" runat="server" Text="Habilitado"></asp:Label>
        <asp:CheckBox ID="chbHabilitado" runat="server" />
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
        <asp:LinkButton ID="AceptarLinkBtn" runat="server" OnClick="AceptarLinkBtn_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="CancelarLinkBtn" runat="server" OnClick="CancelarLinkBtn_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
