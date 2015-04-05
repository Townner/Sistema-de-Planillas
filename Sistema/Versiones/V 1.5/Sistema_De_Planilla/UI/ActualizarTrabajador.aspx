<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ActualizarTrabajador.aspx.cs" Inherits="UI.ActualizarTrabajador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            text-align: left;
            width: 368px;
        }
        .style6
        {
        width: 135px;
        text-align: right;
    }
        .style7
        {
            width: 368px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h4 style="margin-top:10px;"> Modifique los datos del trabajador </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
   
    <tr>
        <td class="style6">
                &nbsp;</td>
        <td class="style7">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" 
                    onblur="javascript:if(this.value == '') this.value='Cedula'"
                Width="139px"></asp:TextBox>
            <asp:Button ID="btnConsultar" runat="server" Text="Consultar" style="float:left; margin-left:62px;"
                onclick="btnConsultar_Click" ValidationGroup="Search" />
            &nbsp;<asp:Button ID="btnNueva" runat="server" onclick="btnNueva_Click" 
                Text="Nueva Consulta" ValidationGroup="New" Visible="False" />
            <br />
            <asp:RegularExpressionValidator ID="RegexCed" runat="server" style="color:Red; float: left; margin-left:10px;"
                ControlToValidate="txtCed" ErrorMessage="Formato permitido 1-1111-1111" 
                ValidationExpression="^\d{1}( |-)\d{4}( |-)\d{4}" ValidationGroup="Search"></asp:RegularExpressionValidator>
            
            <br />
            
            <br />
            <asp:Label ID="lblConfirm" runat="server" ForeColor="green" Text="" 
                Visible="False" style="float:left"></asp:Label>
            <br />
            
        </td>
    </tr>
    <tr>
        <td class="style6">
               Fecha de Vencimiento de Cedula:
               </td>
        <td class="style4">

                <asp:ScriptManager ID="ScriptManager1" runat="server" />
                <hr style="width: 464px" />
                <br />
                <asp:Label ID="lblConfirm0" runat="server" Text="Actual: " 
                    style="float:left; margin-left:10px;"></asp:Label>
                    <asp:Label ID="lblVenCed" runat="server" Text="" style="float:left; margin-left:20px;"></asp:Label>
                <br />
                <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
             <asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
             <asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                 <br />
                 &nbsp; Cambio:
              <asp:Label ID="lblVen_Ced" runat="server" Text="" style="margin-left:10px;"></asp:Label>
                 <br />
              <br />
            <asp:Calendar ID="calven_ced" runat="server" BackColor="White" ondayrender="Calendar1_DayRender"
                    BorderColor="White" Font-Names="Verdana" Font-Size="9pt" 
                    ForeColor="Black" Height="190px" Width="350px" 
                            onselectionchanged="CalVen_Ced_SelectionChanged" BorderWidth="1px" 
                            NextPrevFormat="FullMonth" FirstDayOfWeek="Monday" 
                     ShowGridLines="True" >
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
               </ContentTemplate>
            </asp:UpdatePanel>
               </td>
    </tr>
    <tr>
        <td class="style6">
                Nombre:</td>
        <td class="style4">
                <asp:TextBox ID="txtNom" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<br />
        </td>
    </tr>
    <tr>
        <td class="style6">
                Primer Apellido:</td>
        <td class="style4">
                <asp:TextBox ID="txtAp1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                <br />
        </td>
    </tr>
    <tr>
        <td class="style6">
                Segundo Apellido:</td>
        <td class="style4">
                <asp:TextBox ID="txtAp2" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                
        </td>
    </tr>
    <tr>
        <td class="style6">
                Email:</td>
        <td class="style4">
                <asp:TextBox ID="txtMail" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXEmail" style=" color: Red;"
                    runat="server" ErrorMessage="Formato Correcto: nombre@ejemplo.com" 
                    ControlToValidate="txtMail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
    </tr>
    <tr>
        <td class="style6">
                Telefono Cel:</td>
        <td class="style4">
                <asp:TextBox ID="txtTel1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXCel" runat="server" style=" color:Red;" 
                    ErrorMessage="Formato Correcto: 1111-1111" ControlToValidate="txtTel1" 
                    ValidationExpression="^[0-9]{4}\-[0-9]{4}$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
                Telefono Casa:</td>
        <td class="style4">
                <asp:TextBox ID="txtTel2" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXCasa" runat="server" style=" color:Red;" 
                    ErrorMessage="Formato Correcto: 1111-1111" ControlToValidate="txtTel2" 
                    ValidationExpression="^[0-9]{4}\-[0-9]{4}$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="style6">
                Direccion Exacta:</td>
        <td class="style4">
                <asp:TextBox ID="txtDir" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
                Estado Civil:</td>
        <td class="style4">
        <asp:DropDownList ID="DropEst_Civ" runat="server"
                style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Soltero" Value="Soltero"></asp:ListItem>
                <asp:ListItem Text="Casado" Value="Casado"></asp:ListItem>
                <asp:ListItem Text="Divorciado" Value="Divorcido"></asp:ListItem>
                <asp:ListItem Text="Viudo" Value="Viudo"></asp:ListItem>
                </asp:DropDownList>
                <br />
                </td>
    </tr>
    <tr>
        <td class="style6">
                Nacionalidad:</td>
        <td class="style4">
                <asp:TextBox ID="txtNacionalidad" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
                Departamento:</td>
        <td class="style4">
                 <asp:DropDownList ID="DropDepartamento" runat="server" 
                style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
                Puesto:</td>
        <td class="style4">
                 <asp:DropDownList ID="DropPuesto" runat="server"
                style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
                Experiencia:</td>
        <td class="style4">
                <textarea id="txtExp" name="txtExp" rows="2" cols="20" runat="server"  style="float: left; margin-left:10px;"></textarea></td>
    </tr>
    <tr>
        <td class="style6">
                Titulos:</td>
        <td class="style4">
                <textarea id="txtTitulos" name="txtTitulos" rows="2" runat="server"  style="float: left; margin-left:10px;"></textarea></td>
    </tr>
    <tr>
        <td class="style6">
                Numero de Seguro:
                </td>
        <td class="style4">
                <asp:TextBox ID="txtNum_Seguro" runat="server" 
                    style="float: left; margin-left:10px;" Width="139px" 
                    ></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXSeguro" runat="server" style="color:Red;"
                    ErrorMessage="* Numeros sin guiones de 9 a 10 digitos" 
                    ValidationExpression="^[0-9]{4,6}[0-9]{4}$" 
                    ControlToValidate="txtNum_Seguro" EnableTheming="False"></asp:RegularExpressionValidator>
                </td>
    </tr>
    <tr>
        <td class="style6">
                Dia de Entrega de Uniforme:</td>
        <td class="style4">
                        
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <hr style="width: 464px" />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Actual: " 
                                    style="float:left; margin-left:10px;"></asp:Label>
                                <asp:Label ID="lbluniforme" runat="server" Text="" style="float:left; margin-left:20px;"></asp:Label>
                                <br />
                                <br />
                            <asp:DropDownList id="DPDMonthUniforme" Runat="Server" OnSelectedIndexChanged="Set_CalendarUniforme" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
                            <asp:DropDownList id="DPDYearUniforme" Runat="Server" OnSelectedIndexChanged="Set_CalendarUniforme" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                                <br />
                                &nbsp; Cambio:
                            <asp:Label ID="lblUnif" runat="server" Text="" style="margin-left:10px;"></asp:Label>
                                <br />
                                <br />
                                <asp:Calendar ID="CalUniforme" runat="server" BackColor="White" ondayrender="Calendar1_DayRender"
                                    BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" 
                                    ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" 
                                    onselectionchanged="CalUniforme_SelectionChanged" Width="350px" 
                                    ShowGridLines="True">
                                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
                                        VerticalAlign="Bottom" />
                                    <OtherMonthDayStyle ForeColor="#999999" />
                                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" 
                                        Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                    <TodayDayStyle BackColor="#CCCCCC" />
                                </asp:Calendar>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                </td>
    </tr>
    <tr>
        <td class="style6">
                Estado:
        <td class="style4">
        <asp:DropDownList ID="DropEstado_T" runat="server" 
                    style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Activo" Value="Activo"></asp:ListItem>
                <asp:ListItem Text="Inactivo" Value="Inactivo"></asp:ListItem>
                <asp:ListItem Text="En espera" Value="En espera"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td class="style6">
                Lugar donde esta asignado:</td>
        <td class="style4">
                <asp:TextBox ID="txtL_Trabajo" runat="server" 
                    style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
               
                </td>
    </tr>
    <tr>
        <td class="style6">
                Recontratable:</td>
        <td class="style4">
                <asp:DropDownList ID="DDLRecontratable" runat="server" 
                    style="margin-left:10px;">
                 <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Recontratable" Value="Recontratable"></asp:ListItem>
                <asp:ListItem Text="No Recontratable" Value="No Recontratable"></asp:ListItem>
                </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style6">
                &nbsp;</td>
        <td class="style7">
                <asp:Button ID="btnActua" runat="server" Text="Actualizar" 
                    style="float:left; margin-left:180px;"
                    Visible="False" ValidationGroup="Actualizar" onclick="btnActua_Click"  />
        </td>
    </tr>
    <tr>
        <td class="style6">
                &nbsp;</td>
        <td class="style7">
                &nbsp;</td>
    </tr>
</table>

</asp:Content>
