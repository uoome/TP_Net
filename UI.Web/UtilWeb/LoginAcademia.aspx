<%@ Page Title="" Language="C#" MasterPageFile="~/UtilWeb/SiteLogin.Master" AutoEventWireup="true" CodeBehind="LoginAcademia.aspx.cs" Inherits="UI.Web.UtilWeb.LoginAcademia" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td style="width: 108px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="¡Bienvenido al sistema!"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td style="width: 108px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td style="width: 108px">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td style="width: 108px">
                <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td style="width: 108px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td style="width: 108px">
                <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
            </td>
            <td>
                <asp:LinkButton ID="linkOlvideClave" runat="server" OnClick="linkOlvideClave_Click">Olvide Clave</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 356px">&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="lblLogin" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
