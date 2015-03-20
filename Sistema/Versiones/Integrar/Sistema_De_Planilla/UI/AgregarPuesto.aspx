<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="AgregarPuesto.aspx.cs" Inherits="UI.AgregarPuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

     <h4> Ingrese el nombre del puesto </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
    <tr>
        <td style="text-align: right">
                Nombre:</td>
        <td class="style4">
            <asp:TextBox ID="txtNombre" runat="server" 
                style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
            
            &nbsp;<asp:RequiredFieldValidator ID="RFNombre" runat="server" 
                ControlToValidate="txtNombre" style="color:Red;"
                ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
            <br />
            
        </td>
        <td class="style13">
                </td>
    </tr>
 
    <tr>
        <td>
                &nbsp;</td>
        <td class="style10">
            &nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
 
    <tr>
        <td>
                &nbsp;</td>
        <td class="style5">
                <center>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" 
                    style=" margin-left:-80px; margin-right:auto;" 
                    onclick="btnReg_Click"/>
                </center>
        </td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>
