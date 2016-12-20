<%@ Page Language="C#"  AutoEventWireup="true"  CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

         <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table >
        <tr>
            <td>
            </td>
            <td>
                <asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema! "></asp:Label>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td>
                <asp:Button ID="btnIngresar" runat="server" onclick="btnIngresar_Click" 
                    Text="Ingresar" style="width: 68px" />
            </td>
        </tr>
        </table>
    </div>
    <p>
                <asp:LinkButton ID="lnkRecordarClave" runat="server" 
                    onclick="lnkRecordarClave_Click">Olvide Clave</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblLogin" runat="server" Font-Bold="True" ForeColor="Red" 
            Visible="True"></asp:Label>
    </p>
    
    </div>
    </form>
</body>
</html>
