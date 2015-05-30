<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ActualizarSalarios.aspx.cs" Inherits="UI.ActualizarSalarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style6
        {
        width: 135px;
        text-align: right;
    }
        .style4
        {
            text-align: left;
            width: 368px;
        }
        .style7
        {
            width: 135px;
            text-align: right;
            height: 23px;
        }
        .style8
        {
            text-align: left;
            width: 368px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">
<h4 style="margin-top:10px;"> Modifique los datos del trabajador </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
   
    <tr>
        <td class="style6">
                &nbsp;</td>
        <td class="style7">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:22px;" value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" 
                    onblur="javascript:if(this.value == '') this.value='Cedula'"
                Width="139px"></asp:TextBox>
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" style="float:left; margin-left:62px;"
                onclick="btnConsultar_Click" ValidationGroup="Search" />
            <asp:Button ID="btnNueva" runat="server" onclick="btnNueva_Click" 
                Text="Nueva Consulta" ValidationGroup="New" Visible="False" />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}" ValidationGroup="Search" 
                Height="16px" Width="233px"></asp:RegularExpressionValidator>
            
            &nbsp;<br />
            <asp:Label ID="lblConfirm" runat="server" ForeColor="green" Text="" 
                Visible="False" style="float:left; text-align: left;"></asp:Label>
            <br />
            <br />
            
        </td>
    </tr>
    <tr>
        <td class="style6">
                Salario Base:</td>
        <td class="style4">
                <asp:Label ID="Label1" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtBase" runat="server" style="float: left; margin-left:10px;" 
                    Width="120px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico" runat="server" style=" color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtBase"></asp:RegularExpressionValidator>
                <br />
        </td>
    </tr>
        <tr>
        <td class="style6">
                Hijos Mayores de Edad:</td>
        <td class="style4">
                <asp:TextBox ID="txtMayores" runat="server" style="margin-left:22px;"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td class="style6">
                Hijos Menores de Edad:</td>
        <td class="style4">
                <asp:TextBox ID="txtMenores" runat="server" style="margin-left:22px;"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td class="style6">
                Conyuge:</td>
        <td class="style4">
                <asp:DropDownList ID="DDLConyuge" runat="server" style="margin-left:22px;" 
                    Height="20px" Width="128px">
                <asp:ListItem Text="No Tiene" Value="No Tiene"></asp:ListItem>
                <asp:ListItem Text="Si Tiene" Value="Si Tiene"></asp:ListItem>
                </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td class="style6">
                Monto Prestamo:</td>
        <td class="style4">
                <asp:Label ID="Label5" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtMPrestamo" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico0" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtMPrestamo"></asp:RegularExpressionValidator>
        </td>
        </tr>

    <tr>
        <td class="style7">
                Cuota Prestamo:</td>
        <td class="style8">
                <asp:Label ID="Label6" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtCPrestamo" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico1" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtCPrestamo"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Intereses:</td>
        <td class="style8">
                <asp:TextBox ID="txtIntereses" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:Label ID="lblProcent" runat="server" Text="%" Visible="False" style=" margin-left:10px;"></asp:Label>
                <asp:RegularExpressionValidator ID="REXPorcentaje" runat="server" style=" color: Red;"
                    ErrorMessage="Formato Correcto: 0,XX" 
                    
                    ValidationExpression="\b(0*(?:[0]?|100)\,[0-9]{2})\b" 
                    ControlToValidate="txtIntereses"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Ahorros:</td>
        <td class="style8">
                <asp:Label ID="Label8" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtAhorros" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico3" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtAhorros"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Embargos:</td>
        <td class="style8">
                <asp:Label ID="Label9" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtEmbargos" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico4" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtEmbargos"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adelantos:</td>
        <td class="style8">
                <asp:Label ID="Label10" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtAdelantos" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico5" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtAdelantos"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Otros:</td>
        <td class="style8">
                <asp:Label ID="Label11" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtOtros" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico6" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtOtros"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Monto Subsidio:</td>
        <td class="style8">
                <asp:Label ID="Label12" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtMSubsidio" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico7" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtMSubsidio"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adicional Quincenal:</td>
        <td class="style8">
                <asp:Label ID="Label13" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtAQuincenal" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico8" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtAQuincenal"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adicional Mensual_1:</td>
        <td class="style8">
                <asp:Label ID="Label14" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtAMensual1" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico9" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtAMensual1"></asp:RegularExpressionValidator>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adicional Mensual_2:</td>
        <td class="style8">
                <asp:Label ID="Label15" runat="server" Text="₡" style="float:left;"></asp:Label>
                <asp:TextBox ID="txtAMensual2" runat="server" style="margin-left:10px;"></asp:TextBox>
                <asp:RegularExpressionValidator ID="REXNumerico10" runat="server" style="color: Red;"
                    ErrorMessage="Formato Correcto: 11111.11" 
                    ValidationExpression="([0-9]{5}\,[0-9]{2})" 
                    ControlToValidate="txtAMensual2"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
                &nbsp;</td>
        <td class="style7">
                <asp:Button ID="btnActua" runat="server" Text="Actualizar" 
                    style="float:left; margin-left:180px;"
                    Visible="False" ValidationGroup="Actualizar" onclick="btnActua_Click"  />
        </td>
    </tr>
    <tr>
        <td class="style6">
              &nbsp;</td>
        <td class="style7">
                &nbsp;</td>
    </tr>
</table>
</asp:Content>
