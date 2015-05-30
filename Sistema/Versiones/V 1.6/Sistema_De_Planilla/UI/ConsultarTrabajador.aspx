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
            <td class="style5">
                &nbsp;<asp:TextBox ID="txtCed" runat="server"  value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" onblur="javascript:if(this.value == '') this.value='Cedula'"
                    style="float: left; margin-left:30px;" Width="139px" 
                   ></asp:TextBox>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" 
                    style="float:left; margin-left:150px;" onclick="btnConsultar_Click" 
                    ValidationGroup="Search" />
                <br />
                <asp:CheckBox ID="CBResidencia" runat="server" style="float:left; text-align: left; margin-left:30px; margin-top:-20px;"
                    oncheckedchanged="CheckBox1_CheckedChanged" Text="Cedula de Residencia" 
                    AutoPostBack="true" />
                <br />
                <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}" ValidationGroup="Search"></asp:RegularExpressionValidator>
            
                <br />
            <asp:RegularExpressionValidator ID="RegexCed0" runat="server" style="color:Red;float:left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato Permitido: 111111111111" 
                ValidationExpression="^\d{2}\d{5}\d{5}" ValidationGroup="Search"></asp:RegularExpressionValidator>
            
            </td>
        </tr>
        <tr>
            <td class="style7">
            <div style="overflow-x:auto;width:642px"> 
            <asp:GridView ID="GrdTrabGeneral" runat="server" 
                    style="float:left; margin-left:30px; text-align:center; white-space: nowrap; " ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
            </asp:GridView>
            
             </div>
                
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <div style="overflow-x:auto;width:642px"> 
                <asp:GridView ID="GrdTrabDetalle" runat="server" 
                    style="float:left; margin-left:30px; text-align:center; overflow: hidden; " 
                    ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <div style="overflow-x:auto;width:642px"> 
                <asp:GridView ID="GRHoras" runat="server" style="float:left; margin-left:30px; text-align:center; white-space: nowrap; overflow: hidden; " 
                    ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <div style="overflow-x:auto;width:642px"> 
                <asp:GridView ID="GRFechas" runat="server" style="float:left; margin-left:30px; text-align:center; white-space: nowrap; overflow: hidden; " 
                    ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <div style="overflow-x:auto;width:642px"> 
                <asp:GridView ID="GRLicencias" runat="server" style="float:left; margin-left:30px; text-align:center; white-space: nowrap; overflow: hidden; " 
                    ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <div style="overflow-x:auto;width:642px"> 
                <asp:GridView ID="GRSalario" runat="server" style="float:left; margin-left:30px; text-align:center; white-space: nowrap; overflow: hidden; " 
                    ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <div style="overflow-x:auto;width:642px"> 
                <asp:GridView ID="GRCargos" runat="server" style="float:left; margin-left:30px; text-align:center; white-space: nowrap; overflow: hidden; " 
                    ShowHeaderWhenEmpty="True" CellPadding="4"
         emptydatatext="No hay datos" Width="500px">
                </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
            <center>
                <asp:Button ID="btnNueva" runat="server" style="float:left; margin-left:280px;" onclick="btnNueva_Click1" 
                    Text="Nueva Consulta" />
                    </center>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
