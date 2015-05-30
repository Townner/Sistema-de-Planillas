<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="EliminarPuesto.aspx.cs" Inherits="UI.EliminarPuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            text-align: left;
        }
        .style11
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

 <h4> Ingrese el nombre del puesto </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style11">
                Nombre:</td>
        <td class="style4">
            <asp:TextBox ID="txtNombre" runat="server" 
                style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
            
            &nbsp;
            
            <asp:RequiredFieldValidator ID="RFNombre" runat="server" 
                ControlToValidate="txtNombre" style="color:Red;"
                ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
             CommandName="Delete" 
                onclick="btnConsultar_Click" />
            <br />
            
        </td>
        <td class="style13">
                </td>
    </tr>
 
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
            <asp:GridView ID="GrdPuestos" runat="server" 
                style="margin-left:auto; margin-right:auto; margin-top:20px; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
            </asp:GridView>
        </td>
        <td>
                &nbsp;</td>
    </tr>
 
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
            &nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
 
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style5">
                <center>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" 
                    style=" margin-left:-80px; margin-right:auto;" 
                    OnClientClick="return confirm('Esta seguro que desea eliminar este puesto?');"
                     onclick="btnReg_Click" Visible="False"/>
                </center>
        </td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>
