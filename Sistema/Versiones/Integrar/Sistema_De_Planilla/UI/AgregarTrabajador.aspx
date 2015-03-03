<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="AgregarTrabajador.aspx.cs" Inherits="UI.AgregarTrabajador" %>
<asp:Content ID="Conten1" ContentPlaceHolderID="head" runat="server">
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
        
         .style13
        {
            height: 32px;
        }
        
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

     <h4> Ingrese los datos del trabajador </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">
        ID:</td>
        <td class="style10">
        <asp:TextBox ID="txtID" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFPass13" runat="server" style="float: left; color:Red; margin-left:5px; width: 11px;"
                    ControlToValidate="txtNom" ErrorMessage="*"></asp:RequiredFieldValidator>
        </td>
        <td class="style10">
        </td>
    </tr>
    <tr>
        <td class="style9">
                Cedula:</td>
        <td class="style10">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RFCed" runat="server" ControlToValidate="txtID" style="color:Red;"
                ErrorMessage="Campo Obligatorio"></asp:RequiredFieldValidator>
            <br />
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
               Fecha de Vencimiento de Cedula:
               </td>
        <td class="style10">
            <asp:Label ID="lblVen_Ced" runat="server" Text=""></asp:Label>
                <asp:Calendar ID="CalVen_Ced" runat="server" BackColor="White" 
                    BorderColor="White" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" Width="350px" 
                            onselectionchanged="CalVen_Ced_SelectionChanged" BorderWidth="1px" 
                            NextPrevFormat="FullMonth">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle 
                        VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" 
                        ForeColor="#333333" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" 
                        Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
               </td>
    </tr>
    <tr>
        <td class="style1">
                Nombre:</td>
        <td class="style10">
                <asp:TextBox ID="txtNom" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass" runat="server" style="float: left; color:Red; margin-left:5px; width: 11px;"
                    ControlToValidate="txtNom" ErrorMessage="*"></asp:RequiredFieldValidator>
                <br />
        </td>
        <td class="style13">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Primer Apellido:</td>
        <td class="style10">
                <asp:TextBox ID="txtAp1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFEstado" runat="server"
                    ControlToValidate="txtAp1" ErrorMessage="*" 
                    InitialValue="Default" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
                <br />
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Segundo Apellido:</td>
        <td class="style10">
                <asp:TextBox ID="txtAp2" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFTipo" runat="server" 
                    ControlToValidate="txtAp2" ErrorMessage="*" 
                    InitialValue="Default" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
                
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Email:</td>
        <td class="style10">
                <asp:TextBox ID="txtMail" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass0" runat="server" 
                    ControlToValidate="txtMail" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Telefono Cel:</td>
        <td class="style10">
                <asp:TextBox ID="txtTel1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass1" runat="server" 
                    ControlToValidate="txtTel1" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Telefono Casa:</td>
        <td class="style10">
                <asp:TextBox ID="txtTel2" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass2" runat="server" 
                    ControlToValidate="txtTel2" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Direccion Exacta:</td>
        <td class="style10">
                <asp:TextBox ID="txtDir" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass3" runat="server" 
                    ControlToValidate="txtDir" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Estado Civil:</td>
        <td class="style10">
        <asp:DropDownList ID="DropEst_Civ" runat="server" 
                style="float: left; margin-left:10px;" Width="147px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Soltero" Value="Soltero"></asp:ListItem>
                <asp:ListItem Text="Casado" Value="Casado"></asp:ListItem>
                <asp:ListItem Text="Divorciado" Value="Divorcido"></asp:ListItem>
                <asp:ListItem Text="Viudo" Value="Viudo"></asp:ListItem>
                </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="rfv1" runat="server"
                    ControlToValidate="DropEst_Civ" ErrorMessage="Se requiere ingresar el estado civil" 
                    InitialValue="Default" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
                <br />
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Nacionalidad:</td>
        <td class="style10">
                <asp:TextBox ID="txtNacionalidad" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass4" runat="server" 
                    ControlToValidate="txtNacionalidad" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Departamento:</td>
        <td class="style10">
                 <asp:DropDownList ID="DropDepartamento" runat="server" 
                style="float: left; margin-left:10px;" Width="147px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="rfv2" runat="server" 
                    ControlToValidate="DropDepartamento" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Puesto:</td>
        <td class="style10">
                 <asp:DropDownList ID="DropPuesto" runat="server" 
                style="float: left; margin-left:10px;" Width="147px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="rfv3" runat="server" 
                    ControlToValidate="DropPuesto" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Experiencia:</td>
        <td class="style10">
                <asp:TextBox ID="txtExp" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass7" runat="server" 
                    ControlToValidate="txtExp" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Titulos:</td>
        <td class="style10">
                <asp:TextBox ID="txtTitulos" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass8" runat="server" 
                    ControlToValidate="txtTitulos" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Numero de Seguro:
                </td>
        <td class="style10">
                <asp:TextBox ID="txtNum_Seguro" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass9" runat="server" 
                    ControlToValidate="txtNum_Seguro" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Dia de Entrega de Uniforme:</td>
        <td class="style10">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <asp:Calendar ID="CalUniforme" runat="server" BackColor="White" 
                    BorderColor="White" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" Width="350px" 
                            onselectionchanged="CalUniforme_SelectionChanged" BorderWidth="1px" 
                            NextPrevFormat="FullMonth">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle 
                        VerticalAlign="Bottom" Font-Bold="True" Font-Size="8pt" 
                        ForeColor="#333333" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" 
                        Font-Bold="True" BorderWidth="4px" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
                </td>
        <td class="style10">
        
                </td>
    </tr>
    <tr>
        <td class="style9">
                Estado:
        <td class="style10">
        <asp:DropDownList ID="DropEstado_T" runat="server" 
                    style="float: left; margin-left:10px;" Width="147px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="" Value=""></asp:ListItem>
                <asp:ListItem Text="" Value=""></asp:ListItem>
                <asp:ListItem Text="" Value=""></asp:ListItem>
                <asp:ListItem Text="" Value=""></asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="rfv4" runat="server" 
                    ControlToValidate="DropEstado_T" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Lugar donde va a ser asignado:</td>
        <td class="style10">
                <asp:TextBox ID="txtL_Trabajo" runat="server" 
                    style="float: left; margin-left:10px;" TextMode="Password" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFPass12" runat="server" 
                    ControlToValidate="txtL_Trabajo" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style5">
                <asp:Button ID="btnTrab" runat="server" Text="Agregar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnTrab_Click"/>
        </td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>

