<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ConsultarTrabajador.aspx.cs" Inherits="UI.ConsultarTrabajador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 49px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h4> Ingrese la cedula del trabajador</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
        <tr>
            <td class="style4">
                Cedula:</td>
            <td class="style5">
                <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    style="float:left; margin-left:150px;" onclick="btnConsultar_Click" />
                <br />
                <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}"></asp:RegularExpressionValidator>
            
            </td>
        </tr>
        <tr>
            <td class="style4">
            </td>
            <td class="style7">
            <div style="overflow-x:auto;width:573px"> 
            <asp:GridView ID="GrdTrabGeneral" runat="server"
                    style="float:left; margin-left:30px; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
            </asp:GridView>
            
             </div>
                
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
                <asp:GridView ID="GRHoras" runat="server" 
                    style="margin-left:auto; margin-right:auto; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
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
                <asp:GridView ID="GRFechas" runat="server" 
                    style="margin-left:auto; margin-right:auto; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
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
                <asp:GridView ID="GRLicencias" runat="server" 
                    style="margin-left:auto; margin-right:auto; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
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
                <asp:GridView ID="GRSalario" runat="server" 
                    style="margin-left:auto; margin-right:auto; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
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
                <asp:GridView ID="GRCargos" runat="server" 
                    style="margin-left:auto; margin-right:auto; text-align:center;" ShowHeaderWhenEmpty="True"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
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
                <asp:Button ID="btnNueva" runat="server" style="margin-left:auto; margin-right:auto;" onclick="btnNueva_Click1" 
                    Text="Nueva Consulta" />
            </td>
        </tr>
    </table>

</asp:Content>
