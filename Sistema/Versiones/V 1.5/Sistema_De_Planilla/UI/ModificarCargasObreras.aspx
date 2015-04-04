<%@ Page Title="" Language="C#" MasterPageFile="~/MasterVariablesGlobales.master" AutoEventWireup="true" CodeBehind="ModificarCargasObreras.aspx.cs" Inherits="UI.ModificarCargarObreras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<center>
<h3 style="margin-top:10px;"> Selecione una opcion</h3>
</center>

    <table style="width:100%;">
        <tr>
            <td class="style2" style="width: 201px; height: 26px;">
                &nbsp;</td>
            <td style="height: 26px">
                <asp:CheckBox ID="CBPensionados" runat="server" Text="Pensionados" 
                    style="float:left; margin-left:40px;" AutoPostBack="true" oncheckedchanged="CBPensionados_CheckedChanged"
                     />
            </td>
            <td style="height: 26px">
                <asp:CheckBox ID="CBNoPensionados" runat="server" Text="No Pensionados" AutoPostBack="true"
                    style="float:left; margin-left:30px;" 
                    oncheckedchanged="CBNoPensionados_CheckedChanged"/>
            </td>
        </tr>
        <tr>
            <td class="style2" style="width: 201px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" style="width: 201px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 201px; text-align: right;">
                Valor Actual:</td>
            <td>
                <asp:TextBox ID="txtActual" runat="server" 
                    style=" float:left; margin-left:30px;" Width="120px" 
                    Height="22px" Enabled="False"></asp:TextBox>
                <asp:Label ID="lblProcent" runat="server" Text="%" 
                    style="float:left; margin-left:10px;" Height="16px"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" style="width: 201px; text-align: right; height: 26px;">
                Nuevo Valor:</td>
            <td style="height: 26px">
                <asp:TextBox ID="txtNuevo" runat="server" 
                    style=" float:left; margin-left:30px;" Width="120px" 
                    Height="22px"></asp:TextBox>
                <asp:Label ID="lblProcent0" runat="server" Text="%" 
                    style="float:left; margin-left:10px;" Height="16px"></asp:Label>
                </td>
            <td style="height: 26px">
                <asp:RegularExpressionValidator ID="REXPorcentaje" runat="server" style="float:left; color: Red;"
                    ErrorMessage="Formato Correcto: 0,00%" 
                    
                    ValidationExpression="\b(0*(?:[0-9]{1,2}|100)\,[0-9]{2})\b" 
                    ControlToValidate="txtNuevo"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style2" style="width: 201px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" style="width: 201px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnAplicar" runat="server" Text="Aplicar Cambio" 
                    CommandName="Delete" ValidationGroup="Save" style="float: left; margin-left:60px;"
                OnClientClick="return confirm('Esta seguro que desea aplicar este cambio?');" 
                    onclick="btnAplicar_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
