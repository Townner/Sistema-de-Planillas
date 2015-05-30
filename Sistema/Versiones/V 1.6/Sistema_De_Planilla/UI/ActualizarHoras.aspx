<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ActualizarHoras.aspx.cs" Inherits="UI.ActualizarHoras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 144px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

  <h4 style="margin-top:10px;"> Ingrese los datos del trabajador </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
   
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style10">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" 
                    onblur="javascript:if(this.value == '') this.value='Cedula'"
                Width="139px"></asp:TextBox>
                <asp:CheckBox ID="CBResidencia" runat="server" style="float:left; text-align: left; margin-left:10px;"
                    oncheckedchanged="CheckBox1_CheckedChanged" Text="Cedula de Residencia" 
                    AutoPostBack="true" />
                <asp:Button ID="btConsultarLic" runat="server" Text="Consultar" style="float:left; margin-left:50px;"
                    onclick="btConsultarLic_Click" />
                    <asp:Button ID="btnNew" runat="server" style="float:left; margin-left:20px;" onclick="btnNew_Click" 
                Text="Nueva Consulta" Visible="False" />
                    <br />
                    <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}" ValidationGroup="Search"></asp:RegularExpressionValidator>
            
            <br />
            <asp:RegularExpressionValidator ID="RegexCed1" runat="server" style="color:Red; float: left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato Permitido: 111111111111" 
                ValidationExpression="^\d{2}\d{5}\d{5}"></asp:RegularExpressionValidator>
            
            <br />
            </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style10">
                <asp:Label ID="lblConfirm" runat="server" Text="" Visible="False" 
                    ForeColor="green" style="float: left"></asp:Label>
            
        </td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style10">
                <hr />
            
        </td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                Horas Permiso:</td>
        <td class="style10">
                <asp:TextBox ID="txtPermiso" runat="server" style="float:left; margin-left:20px;"></asp:TextBox>
        </td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                Horas Extra:</td>
        <td class="style10">
                <asp:TextBox ID="txtExtra" runat="server" style="float:left; margin-left:20px;"></asp:TextBox>
        </td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                Horas Incapacidad:</td>
        <td class="style10">
                <asp:TextBox ID="txtIncapacidad" runat="server" style="float:left; margin-left:20px;"></asp:TextBox>
        </td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                Horas Laboradas:</td>
        <td class="style5">
                <asp:TextBox ID="txtLaboradas" runat="server" style="float:left; margin-left:20px;"></asp:TextBox>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
                Horas Subsidio:</td>
        <td class="style5">
                <asp:TextBox ID="txtSubsidio" runat="server" style="float:left; margin-left:20px;"></asp:TextBox>
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
                <asp:Button ID="btnAgregar" runat="server" Text="Actualizar"
                    style="float:left; margin-left:200px;" onclick="btnAgregar_Click" 
                    Visible="False"/>
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
</table>


</asp:Content>
