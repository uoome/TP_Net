<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno/SiteAlumnos.Master" AutoEventWireup="true" CodeBehind="InscripcionACurso.aspx.cs" Inherits="UI.Web.Alumno.InscripcionACurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   

        <asp:Panel ID="panelGrillaCursos" runat="server">
            <asp:GridView ID="grvComisiones" runat="server" AutoGenerateColumns="False" Height="185px" Width="554px">
                <Columns>
                    <asp:BoundField DataField="desc_materia" HeaderText="Materia" />
                    <asp:BoundField DataField="anio" HeaderText="Año" />
                    <asp:BoundField DataField="desc_comi" HeaderText="Comision" />
                    <asp:BoundField DataField="anio_calend" HeaderText="Año calendario" />
                    <asp:BoundField DataField="cupo" HeaderText="Cupo" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            &nbsp;
            <asp:Button ID="btnInscribirse" runat="server" Text="Inscribirse" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" BackColor="White" BorderColor="Red" ForeColor="Red" Text="Una vez realizada la inscripcion no podra eliminarse"></asp:Label>
            <br />
            <asp:Label ID="lblCurso" runat="server" ForeColor="Red" Text="Debe seleccionar un curso" Visible="False"></asp:Label>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
