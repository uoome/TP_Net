<%@ Page Title="" Language="C#" MasterPageFile="~/Alumno/SiteAlumnos.Master" AutoEventWireup="true" CodeBehind="InscripcionACurso.aspx.cs" Inherits="UI.Web.Alumno.InscripcionACurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   

        <asp:Panel ID="panelGrillaCursos" runat="server">
            <asp:GridView ID="grvMaterias" runat="server" AutoGenerateColumns="False" Height="185px" Width="554px" DataKeyNames="ID" OnSelectedIndexChanged="grvMaterias_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Anio" HeaderText="Año" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Materia" />
                    <asp:BoundField DataField="HSSemanales" HeaderText="Horas semanales" />
                    <asp:BoundField DataField="HSTotales" HeaderText="Horas totales" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Panel ID="panelComisiones" runat="server" Visible="False">
                <br />
                <asp:GridView ID="grvComisiones" runat="server" AutoGenerateColumns="False" DataKeyNames="id_cur" OnSelectedIndexChanged="grvComisiones_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="id_cur" HeaderText="Curso" />
                        <asp:BoundField DataField="desc_comi" HeaderText="Comision" />
                        <asp:BoundField DataField="cupo" HeaderText="Cupo" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
                <br />
            </asp:Panel>
            <br />
            &nbsp;
            <asp:Button ID="btnInscribirse" runat="server" Text="Inscribirse" OnClick="btnInscribirse_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" BackColor="White" BorderColor="Red" ForeColor="Red" Text="Una vez realizada la inscripcion no podra eliminarse"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblCurso" runat="server" ForeColor="Red" Text="Ha realizado la inscripcion con exito, puede verificarlo en su estado academico!" Visible="False"></asp:Label>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
