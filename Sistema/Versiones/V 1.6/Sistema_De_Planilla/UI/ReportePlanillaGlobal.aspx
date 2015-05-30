<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Planilla.Master" AutoEventWireup="true" CodeBehind="ReportePlanillaGlobal.aspx.cs" Inherits="UI.ReportPlanillaGlobal" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

    <h4> Reporte Global de Planilla</h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">

            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1395px" 
                ReportSourceID="CRGlobalPlanilla" ToolbarImagesFolderUrl="" 
                ToolPanelWidth="200px" Width="2400px" ToolPanelView="None" 
                RenderingDPI="90" />
            <CR:CrystalReportSource ID="CRGlobalPlanilla" runat="server">
                <report filename="Reports\CRGlobalPlanilla.rpt">
                </report>
            </CR:CrystalReportSource>

        </td>
    </tr>
</table>

</asp:Content>
