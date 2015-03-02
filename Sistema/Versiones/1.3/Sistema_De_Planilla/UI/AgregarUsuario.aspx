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
        .style10
        {
            text-align: left;
            width: 463px;
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

     <h4> Ingrese los datos del usuario </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">
                Cedula:</td>
        <td class="style10">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
            
            &nbsp;<asp:RequiredFieldValidator ID="RFCed" runat="server" ControlToValidate="txtID" style="color:Red;"
                ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
            <br />
            &nbsp;<asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red;"
                ControlToValidate="txtCed" ErrorMessage="Formato Permitido: 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}"></asp:RegularExpressionValidator>
            
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                ID:
 
        <td class="style10">
                <asp:TextBox ID="txtID" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFID" runat="server" style="color:Red;"
                    ControlToValidate="txtID" ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
                <br />
                &nbsp;<asp:RegularExpressionValidator ID="RegexID" runat="server" style="color:Red;"
                    ControlToValidate="txtID" ErrorMessage="Formato Permitido: ejemplo.ejemplo" 
                    ValidationExpression="^[A-Za-z]+\.([A-Za-z]\.)?[A-Za-z]+$"></asp:RegularExpressionValidator>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Contraseña:</td>
        <td class="style5">
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass" runat="server" style="float: left; color:Red; margin-left:5px;"
                    ControlToValidate="txtPass" ErrorMessage="Se requiere una contraseña"></asp:RequiredFieldValidator>
                <br />
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Estado:</td>
        <td class="style5">
                <asp:DropDownList ID="DropEstado" runat="server" style="float: left; margin-left:10px;">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Activado" Value="Activo"></asp:ListItem>
                <asp:ListItem Text="Desactivado" Value="Desactivado"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RFEstado" runat="server"
                    ControlToValidate="DropEstado" ErrorMessage="Se requiere un estado" 
                    InitialValue="Default" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
                <br />
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Tipo:</td>
        <td class="style5">
                <asp:DropDownList ID="DropTipo" runat="server" style="float: left; margin-left:10px;">
                 <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Administrador" Value="Administrador"></asp:ListItem>
                <asp:ListItem Text="Recursos Humanos" Value="Recursos Humanos"></asp:ListItem>
                <asp:ListItem Text="Financiero" Value="Financiero"></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RFTipo" runat="server" 
                    ControlToValidate="DropTipo" ErrorMessage="Se requiere un tipo" 
                    InitialValue="Default" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
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
                <asp:Button ID="btnReg" runat="server" Text="Registrar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnReg_Click"/>
        </td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>
