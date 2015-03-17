<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="RevisiónFinalPlanilla.aspx.cs" Inherits="UI.AprobarPlanilla" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style4
    {
        width: 52px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h3> Revisión Final de Planilla </h3>
    <table style="width:100%;">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                    AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1298px" 
                    ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" 
                    ToolPanelWidth="200px" Width="2016px" />
                <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                    <Report FileName="Reports\CRGlobalPlanilla.rpt">
                    </Report>
                </CR:CrystalReportSource>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


</asp:Content>
