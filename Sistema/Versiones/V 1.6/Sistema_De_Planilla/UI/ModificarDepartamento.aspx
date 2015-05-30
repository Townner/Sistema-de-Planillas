<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ModificarDepartamento.aspx.cs" Inherits="UI.ModificarDepartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

 <h4> Ingrese la cedula del usuario a modificar</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
        <tr>
            <td class="style13">
                Nombre:</td>
            <td class="style14">
                <asp:TextBox ID="txtNombreOld" runat="server" 
                    style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFNombre" runat="server" style="float:left; color: Red; margin-left:10px;" 
                    ControlToValidate="txtNombreOld" ErrorMessage="Campo Requerido"></asp:RequiredFieldValidator>
            
                <asp:Button ID="btnConsulta" runat="server" style="float: left; margin-left:10px;"
                    Text="Consultar" onclick="btnConsulta_Click" />
            
                </td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
            <h4 id ="lblModificar" runat="server" visible="False" style="float:left;"> Modifique el nombre del puesto</h4>
            </td>
        </tr>
        <tr>
            <td id ="lblTipo" runat="server" class="style10">
                Nombre:</td>
            <td class="style5">
                <asp:TextBox ID="txtNombreNew" runat="server"  
                    style="float: left; margin-left:10px;" Width="139px" Visible="False" ></asp:TextBox>
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
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" 
                        style="margin-left:auto; margin-right:auto;" onclick="btnModificar_Click"/>
                </center>
            </td>
        </tr>
    </table>

</asp:Content>
