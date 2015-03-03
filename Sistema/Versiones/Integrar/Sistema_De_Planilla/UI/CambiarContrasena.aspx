<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="UI.Images.CambiarContrasena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            height: 23px;
            width: 176px;
        }
        #lblEstado
        {
            text-align: right;
        }
        .style5
        {
            text-align: right;
        }
        #lblModificar
        {
            text-align: center;
        }
        .style6
        {
            text-align: right;
            width: 176px;
        }
        .style7
        {
            width: 176px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h4> Ingrese la cedula del usuario a modificar</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
        <tr>
            <td class="style6">
                Antigua Contraseña:</td>
            <td class="style5">
                 <center>
                <asp:TextBox ID="txtViejo" runat="server" TextMode="Password" 
                         style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                </center>
                        
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
            <h4 id ="lblModificar" runat="server" style="float:left; margin-left:8px;" > Inserte tu nueva contraseña</h4>

            </td>
        </tr>
        <tr>
            <td id ="lblEstado" runat="server" class="style7">
                Nueva Contraseña:</td>
            <td class="style12">
                <asp:TextBox ID="txtNew" runat="server" TextMode="Password" style="float: left; margin-left:10px;" Width="139px" ></asp:TextBox>
                &nbsp;&nbsp;
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
                <center>
                <asp:Button ID="btnUpdate" runat="server" Text="Modificar" 
                    onclick="btnDelete_Click" style="margin-left:50px; text-align: center; "/>
                </center>
            </td>
        </tr>
    </table>




</asp:Content>
