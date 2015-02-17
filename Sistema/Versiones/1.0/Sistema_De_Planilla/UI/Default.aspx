<%@ Page Theme="Theme_Login" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.WebForm1" %>
<%@ Import Namespace="System.Web.Security" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Sistema de Planilla</title>
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
                    <asp:CheckBox ID="CheckBox1" runat="server" style="padding-left: 50px" Text="Recordarme" />
                    <inpu id="iContrasena" type="password" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                </td>
                <td class="msgIncorrecto">
                    <asp:Label ID="msgIncorrecto" runat="server" 
                        Text="Usuario o Contraseña Incorrecto" Visible="False"></asp:Label>
                    <br />
                    <asp:Label ID="msgDesactivado" runat="server" 
                        Text="Usuario Desactivado" Visible="False"></asp:Label>
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td class="btnOlvido">
                    &nbsp;</td>
                <td class="btnLogin" style="text-align: center">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="Login_Click" />
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
