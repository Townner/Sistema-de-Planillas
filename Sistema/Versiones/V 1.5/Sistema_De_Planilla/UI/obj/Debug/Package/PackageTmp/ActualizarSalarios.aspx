﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ActualizarSalarios.aspx.cs" Inherits="UI.ActualizarSalarios" %>
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
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" 
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
                <asp:TextBox ID="txtBase" runat="server" style="float: left; margin-left:10px;" 
                    Width="139px"></asp:TextBox>
                &nbsp;<br />
        </td>
    </tr>
        <tr>
        <td class="style6">
                Hijos Mayores de Edad:</td>
        <td class="style4">
                <asp:TextBox ID="txtMayores" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td class="style6">
                Hijos Menores de Edad:</td>
        <td class="style4">
                <asp:TextBox ID="txtMenores" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td class="style6">
                Conyuge:</td>
        <td class="style4">
                <asp:TextBox ID="txtConyuge" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
        </tr>
        <tr>
        <td class="style6">
                Monto Prestamo:</td>
        <td class="style4">
                <asp:TextBox ID="txtConyuge0" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
        </tr>

    <tr>
        <td class="style7">
                Cuota Prestamo:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge1" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Intereses:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge2" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Ahorros:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge3" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Embargos:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge4" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adelantos:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge5" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Otros:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge6" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Monto Subsidio:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge7" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adicional Quincenal:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge8" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adicional Mensual_1:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge9" runat="server" style="margin-left:10px;"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td class="style7">
                Adicional Mensual_2:</td>
        <td class="style8">
                <asp:TextBox ID="txtConyuge10" runat="server" style="margin-left:10px;"></asp:TextBox>
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
