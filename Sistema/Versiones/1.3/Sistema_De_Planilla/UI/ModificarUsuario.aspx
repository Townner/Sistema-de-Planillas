 <%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="UI.Images.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .style9
        {
            padding-bottom:10px;
            width: 135px;
            text-align: right;
        }
        .style5
        {
            text-align:left;
            width: 463px;
        }
                        
        .style4
        {
            width: 135px;
        }
        .style10
        {
            width: 135px;
            text-align: right;
        }
        .style11
        {
            width: 135px;
            text-align: right;
            height: 26px;
        }
        .style12
        {
            text-align: left;
            width: 463px;
            height: 26px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">
    
    <h4> Ingrese la cedula del usuario a modificar</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
        <tr>
            <td class="style9">
                Cedula:</td>
            <td class="style5">
                <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnConsultar_Click" />
                <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}"></asp:RegularExpressionValidator>
            
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
            <h4 id ="lblModificar" runat="server"> Modifique los datos del usuario</h4>
            </td>
        </tr>
        <tr>
            <td id ="lblEstado" runat="server" class="style11">
                Estado:</td>
            <td class="style12">
                <asp:DropDownList ID="DropEstado" runat="server">
                <asp:ListItem Text="Administrador" Value="Admin"></asp:ListItem>
                <asp:ListItem Text="Recursos Humanos" Value="RH"></asp:ListItem>
                <asp:ListItem Text="Financiero" Value="FI"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td id ="lblTipo" runat="server" class="style10">
                Tipo:</td>
            <td class="style5">
                <asp:DropDownList ID="DropTipo" runat="server">
                <asp:ListItem Text="Activado" Value="Activado"></asp:ListItem>
                <asp:ListItem Text="Desactivado" Value="Desactivado"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="btnUpdate" runat="server" Text="Modificar" 
                    onclick="btnDelete_Click" style="margin-left:50px;" Visible="False"/>
            </td>
        </tr>
    </table>
</asp:Content>
