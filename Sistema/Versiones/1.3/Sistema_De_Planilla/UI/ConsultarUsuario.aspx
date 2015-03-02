<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="UI.ConsultarUsuario" %>
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
            padding-top:20px; 
            padding-bottom:20px;
            width: 463px;
            height: 23px;
        }
        .style8
        {
            height: 23px;
        }
        
        .style4
        {
            width: 135px;
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

 <h4> Ingrese la cedula del usuario a consultar</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
        <tr>
            <td class="style9">
                Cedula:</td>
            <td class="style5">
                <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnConsultar_Click" />
                <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}"></asp:RegularExpressionValidator>
            
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
            </td>
            <td class="style7">
                <asp:GridView ID="GrdUsers" runat="server" style="margin-left:auto; margin-right:auto; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="300px">
                </asp:GridView>
            </td>
            <td class="style8">
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="btnNueva" runat="server" style="margin-left:auto; margin-right:auto;" onclick="btnNueva_Click1" 
                    Text="Nueva Consulta" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
