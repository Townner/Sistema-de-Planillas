<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.WebForm1" %>
<%@ Import Namespace="System.Web.Security" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Sistema de Planilla</title>
    <link rel="stylesheet" href="/App_Themes/Theme_Login/Login.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div id = "VentanaPrincipal">
      
        <table style="width:100%;">
            <tr>
                <td class="lblUsuario">
                    Usuario:</td>
                <td class="txtUsuario">
                    <asp:TextBox ID="txtUsuario" runat="server" Width="136px" 
                        ontextchanged="Page_Load"></asp:TextBox>
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td class="lblContrasena">
                    Contraseña:</td>
                <td class="txtContrasena">
                    <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" Width="137px"></asp:TextBox>
                    <inpu id="iContrasena" type="password" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="lblContrasena">
                    &nbsp;</td>
                <td class="txtContrasena">
                    <asp:CheckBox ID="CBSesion" runat="server" style=" text-align:center" Text="Mantener Sesion Abierta" />
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="btnOlvido">
                    &nbsp;</td>
                <td class="btnLogin" style="text-align: center">
                    <asp:Button ID="btnLogin" runat="server" Text="Ingresar" 
                        onclick="Login_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="btnOlvido">
                    &nbsp;</td>
                <td class="btnLogin" style="text-align: center">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="btnOlvido">
                    &nbsp;</td>
                <td class="btnLogin" style="text-align: center">
                    <asp:Button ID="btnOlvido" runat="server" Text="¿Olvido su Contraseña?" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
      
    </div>

    

    </form>
</body>
</html>
