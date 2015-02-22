<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="UI.AgregarUsuarioaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style4
        {
            width: 135px;
        }
        .style5
        {
            text-align:center;
            width: 463px;
        }
        .style6
        {
            width: 135px;
            height: 23px;
        }
        .style7
        {
            width: 463px;
            height: 23px;
        }
        .style8
        {
            height: 23px;
        }
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

     <h4> Ingrese los datos del usuario </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">
                Cedula:</td>
        <td class="style5">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                ID:</td>
        <td class="style5">
                <asp:TextBox ID="txtID" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Contraseña:</td>
        <td class="style5">
                <asp:TextBox ID="txtPass" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Estado:</td>
        <td class="style5">
                <asp:TextBox ID="txtState" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Tipo:</td>
        <td class="style5">
                <asp:TextBox ID="txtType" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
                </td>
        <td class="style7">
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style5">
                <asp:Button ID="btnReg" runat="server" Text="Registrar"/>
        </td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>
