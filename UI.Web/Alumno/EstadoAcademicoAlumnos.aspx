<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno/SiteAlumnos.Master" AutoEventWireup="true" CodeBehind="EstadoAcademicoAlumnos.aspx.cs" Inherits="UI.Web.EstadoAcademicoAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">


    <asp:GridView ID="gvEstadoAcademico" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" 
        onload="gvEstadoAcademico_Load" Width="615px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="año" HeaderText="Año" />
            <asp:BoundField DataField="desc_materia" HeaderText="Materia" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:BoundField DataField="desc_plan" HeaderText="Plan" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>




</asp:Content>
