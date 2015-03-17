<%@Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ModificarTrabajador.aspx.cs" Inherits="UI.ModificarTrabajador" %>
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

     <h4> Ingrese los datos del trabajador a modificar</h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
    <tr>
        <td class="style9">
        ID:</td>
        <td class="style10">
        <asp:TextBox ID="txtID" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
           
        </td>
        <td class="style10">
        </td>
    </tr>
    <tr>
        <td class="style9">
                Cedula:</td>
        <td class="style10">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
            &nbsp;
            
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
                &nbsp;<br />
        </td>
        <td class="style13">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Primer Apellido:</td>
        <td class="style10">
                <asp:TextBox ID="txtAp1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
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
                
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Email:</td>
        <td class="style10">
                <asp:TextBox ID="txtMail" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Telefono Cel:</td>
        <td class="style10">
                <asp:TextBox ID="txtTel1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Telefono Casa:</td>
        <td class="style10">
                <asp:TextBox ID="txtTel2" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Direccion Exacta:</td>
        <td class="style10">
                <asp:TextBox ID="txtDir" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
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
                &nbsp;</td>
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
                &nbsp;</td>
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
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Experiencia:</td>
        <td class="style10">
                <asp:TextBox ID="txtExp" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Titulos:</td>
        <td class="style10">
                <asp:TextBox ID="txtTitulos" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Numero de Seguro:
                </td>
        <td class="style10">
                <asp:TextBox ID="txtNum_Seguro" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
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
                <asp:ListItem Text="Activo" Value=""></asp:ListItem>
                <asp:ListItem Text="Inactivo" Value=""></asp:ListItem>
                <asp:ListItem Text="En espera" Value=""></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Lugar donde va a ser asignado:</td>
        <td class="style10">
                <asp:TextBox ID="txtL_Trabajo" runat="server" 
                    style="float: left; margin-left:10px;" TextMode="Password" Width="139px"></asp:TextBox>
                &nbsp;</td>
        <td class="style8">
                </td>
    </tr>
   
        

    </tr>
    <tr>
    <td class="style9">
                Contratable:</td>
        <td class="style10">
                 <asp:DropDownList ID="DropInact" runat="server" 
                style="float: left; margin-left:10px;" Width="147px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Si" Value="Default"></asp:ListItem>
                <asp:ListItem Text="No" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
        <td class="style8">
                </td>
    
    </tr> 
    
    <tr>
        <td class="style4">
                &nbsp;</td>
        <td class="style5">
                <asp:Button ID="btnCons" runat="server" Text="Consultar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnCons_Click"/>
                     <asp:Button ID="btnMod" runat="server" Text="Modificar" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnMod_Click"/>
        </td>
</table>

</asp:Content>

