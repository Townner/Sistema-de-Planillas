<%@ Page Title="" Language="C#" MasterPageFile="~/Master_Page.Master" AutoEventWireup="true" CodeBehind="ActualizarFechas.aspx.cs" Inherits="UI.ActualizarFechas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style4
        {
            width: 167px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipalIzquierdo" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenidoPrincipalCentral" runat="server">

<h4 style=" margin-top:20px;"> Actualización de Horas </h4>
    <table style="width:100%;">
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                <asp:TextBox ID="txtCed" runat="server" style="float:left; margin-left:30px;" 
                    value="Cedula" onfocus="javascript:if(this.value == 'Cedula') this.value=''" 
                    onblur="javascript:if(this.value == '') this.value='Cedula'"></asp:TextBox>
                <asp:Button ID="btnConsul" runat="server" Text="Consultar" 
                    style="float:left; margin-left:30px;" onclick="btnConsul_Click" />
                <asp:Button ID="btnNew" runat="server" onclick="btnNew_Click" 
                    Text="Nueva Consulta" Visible="False" />
                <asp:CheckBox ID="CBResidencia" runat="server" style="float:left; text-align: left; margin-left:10px;"
                    oncheckedchanged="CheckBox1_CheckedChanged" Text="Cedula de Residencia" 
                    AutoPostBack="true" />
                <br />
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
                <asp:Label ID="lblExito" runat="server" Text="" style="float:left; color:Green;"></asp:Label>
                <br />
            
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Fecha de Nacimiento:</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Actual:" Style="float:left; margin-left:20px;"></asp:Label>
                 <asp:Label ID="lblNac" runat="server" Text="" Style="float:left; margin-left:20px;" ></asp:Label>
                 <br />
                 <br />
        
                <asp:Label ID="Label4" runat="server" Text="Cambio:" Style="float:left; margin-left:20px;"></asp:Label>
        
                <asp:TextBox ID="txtNac" runat="server" Style="float:left; margin-left:20px;"></asp:TextBox>
        
            <asp:RegularExpressionValidator ID="RegexCed0" runat="server" style="color:Red; float: left; margin-left:1px;"
                ControlToValidate="txtNac" ErrorMessage="Formato permitido aaaa-mm-dd" 
                ValidationExpression="^\d{4}\-(0[1-9]|1[0-2])\-(0[1-9]|[12][0-9]|3[01])*$" ValidationGroup="Search"></asp:RegularExpressionValidator>
            
                <br />
            
            </td> 
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Fecha de Ingreso:</td>
            <td>
                <hr />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Actual:" Style="float:left; margin-left:20px; margin-bottom:10px;"></asp:Label>
                 <asp:Label ID="lblIngr" runat="server" Style="float:left; margin-left:20px; margin-bottom:10px;" ></asp:Label>
                <br />
                <br />
                <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
             <ContentTemplate>
             <asp:DropDownList id="drpCalMonth" Runat="Server" OnSelectedIndexChanged="Set_CalendarIngreso" AutoPostBack="true" style="float:left; margin-left:30px; margin-bottom:10px;" Width="143px"></asp:DropDownList>
             <asp:DropDownList id="drpCalYear" Runat="Server" OnSelectedIndexChanged="Set_CalendarIngreso" AutoPostBack="true" style="float:left; margin-left:30px; margin-bottom:10px;" Width="143px"></asp:DropDownList> 
                 <br />
                 <br />
             <asp:Label ID="Label3" runat="server" Text="Cambio:" Style="float:left; margin-left:20px; margin-bottom:10px;" ></asp:Label>
                 <asp:Label ID="lblNewIngr" runat="server" Style="float:left; margin-left:20px; margin-bottom:10px;"></asp:Label>
            <asp:Calendar ID="CalIngreso" runat="server" BackColor="White" ondayrender="Calendar1_DayRender"
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Fecha Final de Prueba:</td>
            <td>
                <hr />
                <br />
                <asp:Label ID="Label5" runat="server" 
                    Style="float:left; margin-left:20px; margin-bottom:10px;" Text="Actual:"></asp:Label>
                <asp:Label ID="lblPrueba" runat="server" 
                    Style="float: left; margin-left: 20px; margin-bottom: 10px;"></asp:Label>
                <br />
                <br />
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="drpCalMonth0" Runat="Server" AutoPostBack="true" 
                            OnSelectedIndexChanged="Set_CalendarPrueba" 
                             style="float:left; margin-left:30px; margin-bottom:10px;" Width="143px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="drpCalYear0" Runat="Server" AutoPostBack="true" 
                            OnSelectedIndexChanged="Set_CalendarPrueba" 
                             style="float:left; margin-left:30px; margin-bottom:10px;" Width="143px">
                        </asp:DropDownList>
                 <br />
                 <br />
                        <asp:Label ID="Label6" runat="server" 
                            Style="float:left; margin-left:20px; margin-bottom:10px;" Text="Cambio:"></asp:Label>
                        <asp:Label ID="lblNewPrueba" runat="server" 
                            Style="float:left; margin-left:20px; margin-bottom:10px;"></asp:Label>
                        <asp:Calendar ID="CalFinal_Prueba" runat="server" BackColor="White" 
                            BorderColor="White" BorderWidth="1px" FirstDayOfWeek="Monday" 
                            Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                            NextPrevFormat="FullMonth" ondayrender="Calendar1_DayRender" 
                             ShowGridLines="True" 
                            Width="350px" onselectionchanged="CalFinal_Prueba_SelectionChanged">
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Fecha Salida:</td>
            <td>
                <hr />
                <br />
                <asp:Label ID="Label7" runat="server" 
                    Style="float:left; margin-left:20px; margin-bottom:10px;" Text="Actual:"></asp:Label>
                <asp:Label ID="lblSalida" runat="server" 
                    Style="float: left; margin-left: 20px; margin-bottom: 10px;"></asp:Label>
                <br />
                <br />
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <asp:DropDownList ID="drpCalMonth1" Runat="Server" AutoPostBack="true" 
                            OnSelectedIndexChanged="Set_CalendarSalida" 
                             style="float:left; margin-left:30px; margin-bottom:10px;" Width="143px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="drpCalYear1" Runat="Server" AutoPostBack="true" 
                            OnSelectedIndexChanged="Set_CalendarSalida" 
                             style="float:left; margin-left:30px; margin-bottom:10px;" Width="143px">
                        </asp:DropDownList>
                 <br />
                 <br />
                        <asp:Label ID="Label9" runat="server" 
                            Style="float:left; margin-left:20px; margin-bottom:10px;" Text="Cambio:"></asp:Label>
                        <asp:Label ID="lblNewSalida" runat="server" 
                            Style="float:left; margin-left:20px; margin-bottom:10px;"></asp:Label>
                        <asp:Calendar ID="CalSalida" runat="server" BackColor="White" 
                            BorderColor="White" BorderWidth="1px" FirstDayOfWeek="Monday" 
                            Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" 
                            NextPrevFormat="FullMonth" ondayrender="Calendar1_DayRender" 
                             ShowGridLines="True" 
                            Width="350px" onselectionchanged="CalSalida_SelectionChanged" >
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>   
                <asp:Button ID="btnAct" runat="server" Text="Actualizar" style="float:left; margin-left:170px;"
                    onclick="btnAct_Click" />           
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
