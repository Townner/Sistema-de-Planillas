<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ReportePlanillaGlobal.aspx.cs" Inherits="UI.ReportePlanillaGlobal" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h4> Reporte Global de Planilla</h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">

    <CR:CrystalReportViewer ID="Reporte_Total_Adelantos" runat="server" 
        AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1346px" 
        ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" 
        ToolPanelWidth="100px" Width="1887px" RenderingDPI="100" ToolPanelView="None" 
                HasRefreshButton="True" />

            <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                <Report FileName="Reports\CRGlobalPlanilla.rpt">
                </Report>
            </CR:CrystalReportSource>
            <CR:CrystalReportSource ID="CRPlanillaGlobal" runat="server">
                <Report FileName="CRPlanillaGlobal.rpt">
                </Report>
            </CR:CrystalReportSource>

        </td>
    </tr>
</table>


</asp:Content>
