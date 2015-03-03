<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ReporteTotalAdelantos.aspx.cs" Inherits="UI.ReporteTotalAdelantos" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style9
        {
            padding-bottom:10px;
            width: 135px;
            text-align: right;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

    <h4> Reporte Total de Adelantos </h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">
    <CR:CrystalReportViewer ID="Reporte_Total_Adelantos" runat="server" 
        AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="960px" 
        ReportSourceID="CRTotalAdelantos" ToolbarImagesFolderUrl="" 
        ToolPanelWidth="100px" Width="716px" RenderingDPI="74" ToolPanelView="None" 
                HasRefreshButton="True" />
            <CR:CrystalReportSource ID="CRTotalAdelantos" runat="server">
                <Report FileName="Reports\CRTotalAdelantos.rpt">
                </Report>
            </CR:CrystalReportSource>
        </td>
    </tr>
</table>

    

</asp:Content>
