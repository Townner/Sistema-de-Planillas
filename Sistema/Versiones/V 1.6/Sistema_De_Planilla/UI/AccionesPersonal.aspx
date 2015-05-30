<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="AccionesPersonal.aspx.cs" Inherits="UI.APTresMeses" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

 <h4> Acciones de Personal </h4>
    <table style="width:100px; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">

            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                AutoDataBind="True" GroupTreeImagesFolderUrl="" HasRefreshButton="True" 
                Height="1136px" RenderingDPI="90" ReportSourceID="CRAccionesPersonal" 
                ToolbarImagesFolderUrl="" ToolPanelView="None" ToolPanelWidth="200px" 
                Width="852px" />
            <CR:CrystalReportSource ID="CRAccionesPersonal" runat="server">
                <Report FileName="AccionesPeronal\CRAccionesPersonal.rpt">
                </Report>
            </CR:CrystalReportSource>

        </td>
    </tr>
</table>


</asp:Content>
