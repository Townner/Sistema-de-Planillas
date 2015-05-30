<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="DesactivarTrabajador.aspx.cs" Inherits="UI.DesactivarTrabajador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style5
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">
    <h4> Ingrese la cedula del usuario a eliminar</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style10">
                <asp:TextBox ID="txtCed" runat="server" value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" onblur="javascript:if(this.value == '') this.value='Cedula'" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    style="float:left; margin-left:110px;" onclick="btnConsultar_Click" 
                    ValidationGroup="Search" />
                <br />
                <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left; margin-left: 8px;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}" ValidationGroup="Search"></asp:RegularExpressionValidator>
            
            </td>
            <td class="style11">
                </td>
        </tr>
        <tr>
            <td class="style6">
            </td>
            <td class="style7">
                <asp:GridView ID="GrdTrab" runat="server" 
                    style="margin-left:auto; margin-right:auto; text-align:center; margin-top:10px;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
            </td>
            <td class="style8">
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                
                <asp:Label ID="Label1" 
                    runat="server" Text="Recontrabale:" style="margin-right:10px; margin-left:20px;"></asp:Label>
                <asp:DropDownList ID="DDLRecon" runat="server" 
                    style="margin-left:20px;">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Recontratable" Value="Recontratable"></asp:ListItem>
                <asp:ListItem Text="No Recontratable" Value="No Recontratable"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                <asp:Label ID="Label2" runat="server" Text=" Estado:" style="margin-right:55px; margin-left:20px;"></asp:Label>
                <asp:DropDownList ID="DDLEstado" runat="server" 
                    style="margin-left:20px;">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Activo" Value="Activo"></asp:ListItem>
                <asp:ListItem Text="Inactivo" Value="Inactivo"></asp:ListItem>
                <asp:ListItem Text="En Espera" Value="En Espera"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td class="style5">
                <asp:Button ID="btnDelete" runat="server" Text="Eliminar" 
                    onclick="btnDelete_Click" style="float:left; margin-left:280px;" 
                    Visible="False"/>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>

