<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno/SiteAlumnos.Master" AutoEventWireup="true" CodeBehind="EstadoAcademicoAlumnos.aspx.cs" Inherits="UI.Web.EstadoAcademicoAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">


    <asp:GridView ID="gvEstadoAcademico" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" 
        onload="gvEstadoAcademico_Load" Width="615px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="año" HeaderText="Año" />
            <asp:BoundField DataField="desc_materia" HeaderText="Materia" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:BoundField DataField="nota" HeaderText="Nota" />
            <asp:BoundField DataField="desc_plan" HeaderText="Plan" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" HorizontalAlign="Center" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>




</asp:Content>
