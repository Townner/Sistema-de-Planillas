<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ReporteTotalAhorros.aspx.cs" Inherits="UI.ReporteTotalAhorros" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

    <h4> Reporte Total de Ahorros </h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">

            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" 
                ReportSourceID="CRTotalAhorros" ToolbarImagesFolderUrl="" ToolPanelView="None" 
                ToolPanelWidth="200px" Width="1104px" RenderingDPI="90" />
            <CR:CrystalReportSource ID="CRTotalAhorros" runat="server">
                <Report FileName="Reports\CRTotalAhorros.rpt">
                </Report>
            </CR:CrystalReportSource>

        </td>
    </tr>
</table>

    
</asp:Content>
