<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Planilla.Master" AutoEventWireup="true" CodeBehind="ReporteTotalPlanilla.aspx.cs" Inherits="UI.ReportTotalPlanilla" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h4> Reporte de Total de Planilla</h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">

            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1395px" 
                RenderingDPI="90" ReportSourceID="CRTotalPlanilla" ToolbarImagesFolderUrl="" 
                ToolPanelView="None" ToolPanelWidth="200px" Width="2328px" />
            <CR:CrystalReportSource ID="CRTotalPlanilla" runat="server">
                <report filename="Reports\CRTotalPlanilla.rpt">
                </report>
            </CR:CrystalReportSource>

        </td>
    </tr>
</table>

</asp:Content>
