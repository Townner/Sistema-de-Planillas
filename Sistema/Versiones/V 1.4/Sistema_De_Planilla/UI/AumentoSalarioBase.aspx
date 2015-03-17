<%@ Page Title="" Language="C#" MasterPageFile="~/MasterVariablesGlobales.master" AutoEventWireup="true" CodeBehind="AumentoSalarioBase.aspx.cs" Inherits="UI.AumentoSalarioBase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<center>
<h3> Selecione un puesto </h3>
</center>

    <table style="width:100%;">
        <tr>
            <td class="style2" style="width: 201px; height: 26px;">
                <asp:CheckBox ID="CBMisce" runat="server" Text="Misceláneos" 
                    style="float:left; margin-left:40px;" AutoPostBack="true"
                     />
            </td>
            <td style="height: 26px">
                <asp:CheckBox ID="CBJar" runat="server" Text="Jardineros" AutoPostBack="true"
                    style="float:left; margin-left:40px;"/>
            </td>
            <td style="height: 26px">
                <asp:CheckBox ID="CBChof" runat="server" Text="Choferes" AutoPostBack="true"
                    style="float:left; margin-left:40px;" 
                     />
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
            <td style="width: 201px; text-align: right;">
                Aumento en
                Salario Base:</td>
            <td>
                <asp:CheckBox ID="cbNumerico" runat="server" Text="Numérico" 
                    style="float:left; margin-left:40px;" 
                    oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="true" />
            </td>
            <td>
                <asp:CheckBox ID="cbPorcentual" runat="server" Text="Porcentual" 
                    style="float:left; margin-left:40px;" AutoPostBack="true" 
                    oncheckedchanged="cbPorcentual_CheckedChanged" />
            </td>
        </tr>
        <tr>
            <td class="style2" style="width: 201px">
                &nbsp;</td>
            <td>
                
                <asp:TextBox ID="txtNumerico" runat="server" 
                    style=" float:left; margin-left:30px;" Visible="False" Width="128px" 
                    Height="22px"></asp:TextBox>
                <br />
                <br /> 
                <asp:RegularExpressionValidator ID="REXNumerico" runat="server" style="float:left; color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtNumerico"></asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:TextBox ID="txtProcentual" runat="server" 
                    style=" float:left; margin-left:30px;" Visible="False" Width="120px" 
                    Height="22px"></asp:TextBox>
                <asp:Label ID="lblProcent" runat="server" Text="%" Visible="False" style="float:left; margin-left:10px;"></asp:Label>
                <br />
                <br />
                <asp:RegularExpressionValidator ID="REXPorcentaje" runat="server" style="float:left; color: Red;"
                    ErrorMessage="Formato Correcto: 0.00%" 
                    
                    ValidationExpression="\b(0*(?:[0]?|100)\.[0-9]{2})\b" 
                    ControlToValidate="txtProcentual"></asp:RegularExpressionValidator>
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
                <asp:Button ID="btnAplicar" runat="server" Text="Aplicar" CommandName="Delete" ValidationGroup="Save" style="float: left; margin-left:90px;"
                OnClientClick="return confirm('Esta seguro que desea aplicar este aumento?');" 
                    onclick="btnAplicar_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>


</asp:Content>
