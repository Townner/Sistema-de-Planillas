<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ReporteCumpleanos.aspx.cs" Inherits="UI.ReporteCumpleanos" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

 <h4> Reporte de Cumpleaños </h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">


            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" 
                RenderingDPI="80" ReportSourceID="CRCumpleanos" ToolbarImagesFolderUrl="" 
                ToolPanelView="None" ToolPanelWidth="50px" Width="903px" />
            <CR:CrystalReportSource ID="CRCumpleanos" runat="server">
                <Report FileName="Reports\CRCumpleanos.rpt">
                </Report>
            </CR:CrystalReportSource>


        </td>
    </tr>
</table>

</asp:Content>
