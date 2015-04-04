<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="AgregarTrabajador.aspx.cs" Inherits="UI.AgregarTrabajador" %>
<asp:Content ID="Conten1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">

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
        padding-bottom: 10px;
        width: 200px;
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
        
         #TextArea1
    {
        width: 360px;
    }
        
         .style14
    {
        width: 200px;
    }
        
         </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

    <h4 style="margin-top:10px;"> Ingrese los datos del trabajador </h4>
    <table style="width:100%; margin-top:20px; margin-top:10px;">
   
    <tr>
        <td class="style9">
                Cedula:</td>
        <td class="style10">
            <asp:TextBox ID="txtCed" runat="server" style="float: left; margin-left:10px;" 
                Width="139px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RFCed" runat="server" 
                ControlToValidate="txtCed" style="color:Red;"
                ErrorMessage="* Campo Obligatorio"></asp:RequiredFieldValidator>
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

                <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
             <asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
             <asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_CalendarVen" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                 <br />
              <asp:Label ID="lblVen_Ced" runat="server" Text=""></asp:Label>
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
                 <asp:CustomValidator ID="CustomValidator1" runat="server" 
                     ErrorMessage="CustomValidator"></asp:CustomValidator>
               </ContentTemplate>
            </asp:UpdatePanel>
               </td>
    </tr>
    <tr>
        <td class="style14">
                Nombre:</td>
        <td class="style10">
                <asp:TextBox ID="txtNom" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFNombre" runat="server" style="float: left; color:Red; margin-left:5px; width: 11px;"
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
                <asp:RequiredFieldValidator ID="RRPApellido" runat="server"
                    ControlToValidate="txtAp1" ErrorMessage="*" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
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
                <asp:RequiredFieldValidator ID="SApellido" runat="server" 
                    ControlToValidate="txtAp2" ErrorMessage="*" style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
                
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Email:</td>
        <td class="style10">
                <asp:TextBox ID="txtMail" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXEmail" style=" color: Red;"
                    runat="server" ErrorMessage="Formato Correcto: nombre@ejemplo.com" 
                    ControlToValidate="txtMail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Telefono Cel:</td>
        <td class="style10">
                <asp:TextBox ID="txtTel1" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXCel" runat="server" style=" color:Red;" 
                    ErrorMessage="Formato Correcto: 1111-1111" ControlToValidate="txtTel1" 
                    ValidationExpression="^[0-9]{4}\-[0-9]{4}$"></asp:RegularExpressionValidator>
        </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Telefono Casa:</td>
        <td class="style10">
                <asp:TextBox ID="txtTel2" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXCasa" runat="server" style=" color:Red;" 
                    ErrorMessage="Formato Correcto: 1111-1111" ControlToValidate="txtTel2" 
                    ValidationExpression="^[0-9]{4}\-[0-9]{4}$"></asp:RegularExpressionValidator>
        </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Direccion Exacta:</td>
        <td class="style10">
                <asp:TextBox ID="txtDir" runat="server" style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RFDirreccion" runat="server" 
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
                style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Soltero" Value="Soltero"></asp:ListItem>
                <asp:ListItem Text="Casado" Value="Casado"></asp:ListItem>
                <asp:ListItem Text="Divorciado" Value="Divorcido"></asp:ListItem>
                <asp:ListItem Text="Viudo" Value="Viudo"></asp:ListItem>
                </asp:DropDownList>
                 <asp:RequiredFieldValidator ID="RFCivil" runat="server"
                    ControlToValidate="DropEst_Civ" ErrorMessage="* Campo Obligatorio" 
                    InitialValue="Default" 
                style="float: left; margin-left:5px; color: Red;"></asp:RequiredFieldValidator>
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
                &nbsp;<asp:RequiredFieldValidator ID="RFNacio" runat="server" 
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
                style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="RFDep" runat="server" 
                    ControlToValidate="DropDepartamento" ErrorMessage="*" InitialValue="Default" 
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
                style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="RFPuesto" runat="server" 
                    ControlToValidate="DropPuesto" ErrorMessage="*" InitialValue="Default" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Experiencia:</td>
        <td class="style10">
                <textarea id="txtExp" name="txtExp" rows="2" cols="20" runat="server"  style="float: left; margin-left:10px;"></textarea></td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Titulos:</td>
        <td class="style10">
                <textarea id="txtTitulos" name="txtTitulos" rows="2" runat="server"  style="float: left; margin-left:10px;"></textarea></td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Numero de Seguro:
                </td>
        <td class="style10">
                <asp:TextBox ID="txtNum_Seguro" runat="server" 
                    style="float: left; margin-left:10px;" Width="139px" 
                    ></asp:TextBox>
                &nbsp;<asp:RegularExpressionValidator ID="RGXSeguro" runat="server" style="color:Red;"
                    ErrorMessage="* Numeros sin guiones de 9 a 10 digitos" 
                    ValidationExpression="^[0-9]{4,6}[0-9]{4}$" 
                    ControlToValidate="txtNum_Seguro" EnableTheming="False"></asp:RegularExpressionValidator>
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Dia de Entrega de Uniforme:</td>
        <td class="style10">
                        
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                            <asp:DropDownList id="DPDMonthUniforme" Runat="Server" OnSelectedIndexChanged="Set_CalendarUniforme" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
                            <asp:DropDownList id="DPDYearUniforme" Runat="Server" OnSelectedIndexChanged="Set_CalendarUniforme" AutoPostBack="true" style="margin-left:10px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                                <br />
                            <asp:Label ID="lblUnif" runat="server" Text=""></asp:Label>
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
        <td class="style10">
        
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style9">
                Estado:
        <td class="style10">
        <asp:DropDownList ID="DropEstado_T" runat="server" 
                    style="float: left; margin-left:10px;" Width="143px">
                <asp:ListItem Text="Selecione un valor" Value="Default"></asp:ListItem>
                <asp:ListItem Text="Activo" Value="Activo"></asp:ListItem>
                <asp:ListItem Text="Inactivo" Value="Inactivo"></asp:ListItem>
                <asp:ListItem Text="En espera" Value="En espera"></asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RFEstado" runat="server" InitialValue="Default" style="color:Red;"
                ErrorMessage="* Campo Obligatorio" ControlToValidate="DropEstado_T"></asp:RequiredFieldValidator>
        </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                Lugar donde va a ser asignado:</td>
        <td class="style10">
                <asp:TextBox ID="txtL_Trabajo" runat="server" 
                    style="float: left; margin-left:10px;" Width="139px"></asp:TextBox>
               
                <asp:RequiredFieldValidator ID="RFLugar" runat="server" 
                    ControlToValidate="txtL_Trabajo" ErrorMessage="*" 
                    style="float: left; color:Red; margin-left:5px;"></asp:RequiredFieldValidator>
               
                </td>
        <td class="style8">
                </td>
    </tr>
    <tr>
        <td class="style9">
                &nbsp;</td>
        <td class="style10">
                &nbsp;</td>
        <td class="style8">
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style14">
                &nbsp;</td>
        <td class="style5">
                <asp:Button ID="btnTrab" runat="server" Text="Agregar Trabajador" 
                    style="margin-left:auto; margin-right:auto;" onclick="btnTrab_Click"/>
        </td>
        <td>
                &nbsp;</td>
    </tr>
    <tr>
        <td class="style14">
                &nbsp;</td>
        <td class="style5">
                &nbsp;</td>
        <td>
                &nbsp;</td>
    </tr>
</table>

</asp:Content>

